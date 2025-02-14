using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.CompilerServices;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.RouteAvailability;

public static class RouteAvailabilityEndpoints
{
    public static void AddDepartureEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/departures", async (string start, string end, DateTime date, TrainTicketingDbContext dbContext, CancellationToken ctx) =>
        {

            try
            {
                ArgumentException.ThrowIfNullOrEmpty(start, nameof(start));
                ArgumentException.ThrowIfNullOrEmpty(end, nameof(end));
                ArgumentException.ThrowIfNullOrEmpty(date.ToString(), nameof(date));
            }
            catch (ArgumentException aex)
            {
                return Results.BadRequest(aex.Message);
            }

            if(!Guid.TryParse(start, out var startId))
            {
                return Results.BadRequest("Invalid start station id");
            }
            if (!Guid.TryParse(end, out var endId))
            {
                return Results.BadRequest("Invalid end station id");
            }

            var startStation = await dbContext.Stations.FirstOrDefaultAsync(s => s.StationId == startId);
            var endStation = await dbContext.Stations.FirstOrDefaultAsync(s => s.StationId == endId);

            if (startStation is null)
            {
                return Results.NotFound("The starting station does not exist");
            }
            if (endStation is null)
            {
                return Results.NotFound("The ending station does not exist");
            }

            var routesAvailable = await dbContext.DepartureDates
                                            .Where(dd => DateTime.Equals(dd.DateOfDeparture, date))
                                            .Include(dd => dd.Departure)
                                                .ThenInclude(d => d.Route)
                                                .ThenInclude(r => r.RouteDetails)
                                            .Where(dd =>
                                                    dd.Departure.Route.RouteDetails.Select(rd => rd.StationId).Any(stationId => stationId == startId) &&
                                                    dd.Departure.Route.RouteDetails.Select(rd => rd.StationId).Any(stationId => stationId == endId))
                                            .Include(dd => dd.Departure)
                                                .ThenInclude(d => d.Train)
                                             .Include(dd => dd.Departure)
                                                .ThenInclude(d => d.DepartureDetails)
                                                .ThenInclude(dd => dd.RouteDetail)
                                            .ToListAsync(ctx);

            var responseOfRoutes = routesAvailable
                                .Select(ra => new AvailableRoutesFromSpecifiedStationsAndDateDto(
                                        ra.Departure.Train.TrainName,
                                        ra.Departure.DepartureDetails.First(dd => dd.RouteDetail.StationId == startId).DepatureTime,
                                        ra.Departure.DepartureDetails.Where(dd => dd.RouteDetail.StationId == endId).First().DepatureTime
                                ));

            return Results.Ok(responseOfRoutes);
        });
    }
}
