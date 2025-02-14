using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainTicketing.Api.Endpoints.Routes;
using TrainTicketing.Api.HostedServices;
using TrainTicketing.Database;

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

builder.Services
    .AddDbContext<TrainTicketingDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); 
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.AddRouteEndpoints();
app.MapControllers();

app.Run();
