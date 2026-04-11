using Microsoft.EntityFrameworkCore;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.RouteAvailability;

public static class RouteAvailabilityEndpoints
{
    public static void AddDepartureEndpoints(this IEndpointRouteBuilder app)
    {
        //TODO : functionality where stations are on different routes and have common node so API will respond with change train at common node
        app.MapGet("/departures", async (string departureStation, string arrivalStation, DateTime date, TrainTicketingDbContext dbContext, ILogger<Program> _logger, CancellationToken ctx) =>
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

            if (!Guid.TryParse(departureStation, out var departureStationId))
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

            // All routes available that contain the two stations in the url. 
            var routesAvailable = await dbContext.DailyDepartures
                                            .Where(dd => DateTime.Equals(dd.DateOfDeparture, date))
                                            .Include(dd => dd.DepartureSchedule)
                                                .ThenInclude(d => d.Route)
                                                .ThenInclude(r => r.RouteDetails)
                                            .Where(dd =>
                                                    dd.DepartureSchedule.Route.RouteDetails.Select(rd => rd.StationId).Any(stationId => stationId == departureStationId) &&
                                                    dd.DepartureSchedule.Route.RouteDetails.Select(rd => rd.StationId).Any(stationId => stationId == arrivalStationId))
                                            .Include(dd => dd.DepartureSchedule)
                                                .ThenInclude(d => d.Train)
                                             .Include(dd => dd.DepartureSchedule)
                                                .ThenInclude(d => d.DepartureDetails)
                                                .ThenInclude(dd => dd.RouteDetail)
                                            .ToListAsync(ctx);

            // Filter the routes available by the outbound main rule : if the departure station is before the arrival station in the route details, then it is outbound main.
            // This is to get the routes that are going from the departure station to the arrival station.
            var routesAvailableFilteredByOutbound = routesAvailable
                .Where(ra => ra.DepartureSchedule.OutboundMain ==
                            (ra.DepartureSchedule.Route.RouteDetails.First(rd => rd.StationId == departureStationId).OrderOfStationFromMain <
                             ra.DepartureSchedule.Route.RouteDetails.First(rd => rd.StationId == arrivalStationId).OrderOfStationFromMain))
                .ToList();
            _logger.LogDebug(routesAvailableFilteredByOutbound.ToString());

            // need to return the departureDateId.
            var responseOfRoutes = routesAvailableFilteredByOutbound
                                .Select(ra => new AvailableRoutesFromSpecifiedStationsAndDateDto(
                                            ra.DepartureSchedule.Train!.TrainName,
                                            ra.DepartureSchedule.DepartureDetails.First(dd => dd.RouteDetail.StationId == departureStationId).DepatureTime,
                                            ra.DepartureSchedule.DepartureDetails.Where(dd => dd.RouteDetail.StationId == arrivalStationId).First().DepatureTime,
                                            ra.DailyDepartureId,
                                            ra.DepartureSchedule.DepartureDetails.First(dd => dd.RouteDetail.StationId == departureStationId).RouteDetailId,
                                            ra.DepartureSchedule.DepartureDetails.Where(dd => dd.RouteDetail.StationId == arrivalStationId).First().RouteDetailId
                                ));

            return Results.Ok(responseOfRoutes);
        });
    }
}
