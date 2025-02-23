using DDD.EF.OptimisticConcurrency.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.RouteReservation;

public static class RouteReservationEndpoints
{
    public static void AddRouteReservationEndpoints(this IEndpointRouteBuilder app)
    {
        //TODO add params as request class
        //TODO verifica sa fie de ruta acele detailii, sanitizare tot input
        app.MapPost("/reserve-seat", 
            async(SeatReservationRequest seatReservationRequest,
                  TrainTicketingDbContext dbContext,
                  UserManager<IdentityUser> userManager,
                  HttpContext httpContext,
                  ILogger<Program> _logger,
                  CancellationToken ctx) =>
        {
            var user = await userManager.GetUserAsync(httpContext.User);
            if (user == null)
            {
                return Results.Unauthorized();
            }

            var dailyDeparture = await dbContext.DailyDepartures
                                                    .Where(dd => dd.DailyDepartureId == seatReservationRequest.DailyDepartureId)
                                                    .Include(dd => dd.DepartureSchedule)
                                                        .ThenInclude(ds => ds.Train)
                                                            .ThenInclude(t => t.Seats)
                                                     .Include(dd => dd.DepartureSchedule)
                                                        .ThenInclude(ds => ds.DepartureDetails)
                                                    .AsSplitQuery()
                                                    .FirstAsync();
            if (dailyDeparture is null)
            {
                return Results.NotFound("Daily departure not found");
            }

            var departureRouteDetail = await dbContext.RouteDetails.FirstOrDefaultAsync(rd => rd.Id == seatReservationRequest.DepartureRouteDetailId, ctx);
            var arrivalRouteDetail = await dbContext.RouteDetails.FirstOrDefaultAsync(rd => rd.Id == seatReservationRequest.ArrivalRouteDetailId, ctx);
            if (departureRouteDetail is null)
            {
                return Results.NotFound("Departure route detail not found");
            }
            if (arrivalRouteDetail is null)
            {
                return Results.NotFound("Arrival route detail not found");
            }

            dailyDeparture.AddReservation(user, departureRouteDetail, arrivalRouteDetail);

            var domainEvents = DomainEventsHelper.GetAllDomainEvents(dailyDeparture);
            if (domainEvents.Any())
            {
                dailyDeparture.IncreaseVersion();
            }

            try
            {
                await dbContext.SaveChangesAsync(ctx);
            }
            catch (DbUpdateConcurrencyException ce)
            {
                return Results.Conflict($"Error occurred on seat reservation. Try reserving again!\n{ce.Message}");
            }

            return Results.Created();
        }).RequireAuthorization("ClientPolicy");
    }
}


