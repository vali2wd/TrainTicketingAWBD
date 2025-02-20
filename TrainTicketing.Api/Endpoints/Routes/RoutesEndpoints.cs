using Microsoft.EntityFrameworkCore;
using System.Linq;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.Routes;

public static class RoutesEndpoints
{
    public static void AddRouteEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/routes", async (TrainTicketingDbContext dbContext) =>
        {
            var routes = await dbContext
                            .Routes
                            .AsNoTracking()
                            .Select(r => new RouteWithNameAndImageDto(r.RouteId, r.RouteName, r.ImagePath))
                            .ToListAsync();

            return Results.Ok(routes);
        });

        app.MapGet("/route/{routeId}", async (string routeId, TrainTicketingDbContext dbContext) =>
        {
            if (!Guid.TryParse(routeId, out Guid routeGuid))
            {
                return Results.BadRequest("Invalid route id");
            };

            var route = await dbContext.Routes
                .AsNoTracking()
                .Where(r => r.RouteId == routeGuid)
                .Include(r => r.MainTerminal)
                .FirstOrDefaultAsync();
            
            if (route is null)
            {
                return Results.NotFound();
            }

            var stationNamesOrdered = await dbContext.RouteDetails.Where(rd => rd.RouteId == routeGuid)
                .OrderBy(rd => rd.OrderOfStationFromMain)
                .Include(rd => rd.Station)
                .Select(rd => rd.Station.StationName)
                .ToListAsync();

            var routeTotalDistance = route.TotalDistance;

            var departuresTimetable =
                await dbContext.DepartureSchedules
                                    .AsNoTracking()
                                    .Where(r => r.RouteId == routeGuid)
                                    .Include(d => d.Train)
                                    .Include(d => d.DepartureDetails)
                                        .ThenInclude(dd => dd.RouteDetail)
                                    .Select(d => new RouteDepartureAndTimesDto( d.OutboundMain, d.Train.TrainName, d.DepartureDetails.Select(dd => dd.DepatureTime).ToList()))
                                    .ToListAsync();

            foreach(var departureTimetable in departuresTimetable)
            {
                departureTimetable.DepartureTimes.OrderBy(dt => dt * (departureTimetable.OutbountMain == true ? 1 : -1));
            }

            RouteTimetableDto routeTimetable = new RouteTimetableDto(route.MainTerminal.StationName, stationNamesOrdered, departuresTimetable);

            return Results.Ok(routeTimetable);
        });
    }
}
