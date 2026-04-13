using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using TrainTicketing.Api.Endpoints.Generic;
using TrainTicketing.Api.Endpoints.RouteAvailability;
using TrainTicketing.Api.Endpoints.RouteReservation;
using TrainTicketing.Api.Endpoints.Routes;
using TrainTicketing.Api.Endpoints.Stations;
using TrainTicketing.Api.HostedServices;
using TrainTicketing.Api.LifeTimes;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Entities;
using Route = TrainTicketing.DomainModel.Entities.Route;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services
    .AddAuthorization();
builder.Services
    .AddIdentityApiEndpoints<IdentityUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<TrainTicketingDbContext>();

if (builder.Environment.IsEnvironment("Test"))
{
    builder.Services.AddDbContext<TrainTicketingDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}
else
{
    builder.Services
        .AddDbContext<TrainTicketingDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("ClientPolicy", policy =>
        policy.RequireRole("Client"));
    options.AddPolicy("WorkerPolicy", policy =>
        policy.RequireRole("Worker"));
});

builder.Services.AddAppServices();

builder.Services.AddHttpClient("NotificationClient", client =>
{
    client.BaseAddress = new Uri("http://localhost:5127");
});

builder.Services
    .AddEndpointsApiExplorer();
builder.Services
    .AddSwaggerGen(options =>
    {
        options.AddSecurityDefinition("oauth2", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
        {
            In = Microsoft.OpenApi.Models.ParameterLocation.Header,
            Name = "Authorization",
            Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey
        });
    }
    );

builder.Services
    .AddHostedService<DeparturePlanningJob>();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
    .MinimumLevel.Override("Microsoft.Extensions.Hosting", LogEventLevel.Information)
    .MinimumLevel.Override("Microsoft.Hosting", LogEventLevel.Information)
    // Sink 1
    .WriteTo.Console()
    // Sink 2: Errors
    .WriteTo.File("logs/errors-.txt",
        rollingInterval: RollingInterval.Day,
        restrictedToMinimumLevel: LogEventLevel.Error,
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

builder.Services.AddSerilog();


var app = builder.Build();

Console.WriteLine($"*** RUNNING IN ENVIRONMENT: {app.Environment.EnvironmentName} ***");
Console.WriteLine($"*** DB CONNECTION: {app.Configuration.GetConnectionString("DefaultConnection")} ***");

app.UseSerilogRequestLogging();

app.MapGroup("/identity").MapIdentityApi<IdentityUser>();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Test"))
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
// Endpoints
app.AddRouteEndpoints();
app.AddStationsEndpoints();
app.AddDepartureEndpoints();
app.AddRouteReservationEndpoints();

// Generic
app.MapGenericEndpoints<Announcement, TrainTicketingDbContext>("/api/Announcement");
app.MapGenericEndpoints<DepartureDetail, TrainTicketingDbContext>("/api/DepartureDetail");
app.MapGenericEndpoints<DepartureSchedule, TrainTicketingDbContext>("/api/DepartureSchedule");
app.MapGenericEndpoints<Reservation, TrainTicketingDbContext>("/api/Reservation");
app.MapGenericEndpoints<ReservationsArchive, TrainTicketingDbContext>("/api/ReservationsArchive");
app.MapGenericEndpoints<Route, TrainTicketingDbContext>("/api/Route");
app.MapGenericEndpoints<RouteDetail, TrainTicketingDbContext>("/api/RouteDetail");
app.MapGenericEndpoints<Seat, TrainTicketingDbContext>("/api/Seat");
app.MapGenericEndpoints<Station, TrainTicketingDbContext>("/api/Station");
app.MapGenericEndpoints<TariffRanges, TrainTicketingDbContext>("/api/TariffRanges");
app.MapGenericEndpoints<TariffSchema, TrainTicketingDbContext>("/api/TariffSchema");

// Map Controllers
app.MapControllers();


//CORS for SPA development - Angular
app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:4200")
        .AllowAnyHeader()
        .AllowAnyMethod();
});

app.Run();

public partial class Program { }