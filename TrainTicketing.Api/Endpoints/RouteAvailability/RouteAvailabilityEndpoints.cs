using Microsoft.EntityFrameworkCore;
using System.Linq;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.RouteAvailability;

public static class RouteAvailabilityEndpoints
{
    public static void AddDepartureEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/departures", async (string departureStation, string arrivalStation, DateTime date, TrainTicketingDbContext dbContext, CancellationToken ctx) =>
        {
            try
            {
                ArgumentException.ThrowIfNullOrEmpty(departureStation, nameof(departureStation));
                ArgumentException.ThrowIfNullOrEmpty(arrivalStation, nameof(arrivalStation));
                ArgumentException.ThrowIfNullOrEmpty(date.ToString(), nameof(date));
            }
            catch (ArgumentException aex)
            {
                return Results.BadRequest(aex.Message);
            }

            if(!Guid.TryParse(departureStation, out var departureStationId))
            {
                return Results.BadRequest("Invalid start station id");
            }
            if (!Guid.TryParse(arrivalStation, out var arrivalStationId))
            {
                return Results.BadRequest("Invalid end station id");
            }

            var startStation = await dbContext.Stations.FirstOrDefaultAsync(s => s.StationId == departureStationId);
            var endStation = await dbContext.Stations.FirstOrDefaultAsync(s => s.StationId == arrivalStationId);

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
                                                    dd.Departure.Route.RouteDetails.Select(rd => rd.StationId).Any(stationId => stationId == departureStationId) &&
                                                    dd.Departure.Route.RouteDetails.Select(rd => rd.StationId).Any(stationId => stationId == arrivalStationId))
                                            .Include(dd => dd.Departure)
                                                .ThenInclude(d => d.Train)
                                             .Include(dd => dd.Departure)
                                                .ThenInclude(d => d.DepartureDetails)
                                                .ThenInclude(dd => dd.RouteDetail)
                                            .ToListAsync(ctx);

            var routesAvailableFilteredByOutbound = routesAvailable
                .Where(ra => ra.Departure.OutboundMain == 
                            (ra.Departure.Route.RouteDetails.First(rd => rd.StationId == departureStationId).OrderOfStationFromMain <
                             ra.Departure.Route.RouteDetails.First(rd => rd.StationId == arrivalStationId).OrderOfStationFromMain))
                .ToList();

            var responseOfRoutes = routesAvailableFilteredByOutbound
                                .Select(ra => new AvailableRoutesFromSpecifiedStationsAndDateDto(
                                        ra.Departure.Train.TrainName,
                                        ra.Departure.DepartureDetails.First(dd => dd.RouteDetail.StationId == departureStationId).DepatureTime,
                                        ra.Departure.DepartureDetails.Where(dd => dd.RouteDetail.StationId == arrivalStationId).First().DepatureTime
                                ));

            return Results.Ok(responseOfRoutes);
        });
    }
}
