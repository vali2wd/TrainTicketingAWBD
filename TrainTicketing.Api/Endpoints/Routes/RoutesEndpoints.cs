using Microsoft.EntityFrameworkCore;
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

            var route = await dbContext
                            .Routes
                            .AsNoTracking()
                            .Where(r => r.RouteId == routeGuid)
                            .FirstOrDefaultAsync();
            if (route is null)
            {
                return Results.NotFound();
            }
            var routeTotalDistance = route.TotalDistance;

            var departures = 
                await dbContext.Departures
                                    .AsNoTracking()
                                    .Where(r => r.RouteId == routeGuid)
                                    .Include(d => d.DepartureDetails)
                                        .ThenInclude(dd => dd.RouteDetail)
                                        .ThenInclude(rd => rd!.Station)
                                    .Include(d => d.Train)
                                    .Select(d => new
                                    {
                                        TrainName = d.Train.TrainName,
                                        DepartureDetails = d.DepartureDetails
                                        .OrderBy(dd => dd.OutboundMain == true ? dd.RouteDetail.OrderOfStationFromMain : -dd.RouteDetail.OrderOfStationFromMain)
                                        .Select(dd => new
                                        {
                                            Distance = dd.OutboundMain == true ? dd.RouteDetail.DistanceFromMain : routeTotalDistance - dd.RouteDetail.DistanceFromMain,
                                            DepartureTime = dd.DepatureTime,
                                            Station = dd.RouteDetail.Station.StationName
                                        })
                                    })
                                    .ToListAsync();

            if (departures is null)
            {
                return Results.NotFound();
            }

            return Results.Ok(departures);
        });
    }
}
