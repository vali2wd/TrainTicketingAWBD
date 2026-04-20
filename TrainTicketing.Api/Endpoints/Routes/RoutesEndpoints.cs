using Microsoft.EntityFrameworkCore;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

        app.MapGet("/routes-pg", async (TrainTicketingDbContext dbContext, [AsParameters] QueryParameters queryParameters) =>
        {
            var routesQuery = dbContext.Routes.AsNoTracking();

            routesQuery = (queryParameters.SortByA, queryParameters.SortByB) switch
            {
                (true, _) => routesQuery.OrderBy(r => r.RouteName),
                (false, _) => routesQuery.OrderByDescending(r => r.RouteName),
                (null, true) => routesQuery.OrderBy(r => r.TotalDistance),
                (null, false) => routesQuery.OrderByDescending(r => r.TotalDistance),
                _ => routesQuery.OrderBy(r => r.RouteId)
            };

            var totalCount = await routesQuery.CountAsync();

            var items = await routesQuery
                            .Skip((queryParameters.PageNumber - 1) * queryParameters.PageSize) // Move the pointer
                            .Take(queryParameters.PageSize) // Grab only the slice we need
                            .Select(r => new RouteWithNameAndImageDto(r.RouteId, r.RouteName, r.ImagePath))
                            .ToListAsync();

            var response = new PaginationResponse<RouteWithNameAndImageDto>(
                items,
                totalCount,
                queryParameters.PageNumber,
                queryParameters.PageSize
            );

            return Results.Ok(response);
        }).RequireAuthorization("ClientPolicy");


        app.MapGet("/route/{routeId}", async (string routeId, TrainTicketingDbContext dbContext) =>
        {
            if (!Guid.TryParse(routeId, out Guid routeGuid))
            {
                return Results.BadRequest("Invalid route id");
            }
            ;

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
                                    .Select(d => new RouteDepartureAndTimesDto(d.OutboundMain, d.Train.TrainName, d.DepartureDetails.Select(dd => dd.DepatureTime).ToList()))
                                    .ToListAsync();

            foreach (var departureTimetable in departuresTimetable)
            {
                departureTimetable.DepartureTimes.OrderBy(dt => dt * (departureTimetable.OutbountMain == true ? 1 : -1));
            }

            RouteTimetableDto routeTimetable = new RouteTimetableDto(route.MainTerminal.StationName, stationNamesOrdered, departuresTimetable);

            return Results.Ok(routeTimetable);
        });

        //get tariffschema for route
        app.MapGet("/route/{routeId}/tariff", async (string routeId, TrainTicketingDbContext dbContext) =>
        {
            if (!Guid.TryParse(routeId, out Guid routeGuid))
            {
                return Results.BadRequest("Invalid route id");
            }
            ;

            var route = await dbContext.Routes
                .AsNoTracking()
                .Where(r => r.RouteId == routeGuid)
                .Include(r => r.TariffSchema)
                    .ThenInclude(ts => ts.TariffRanges)
                .FirstOrDefaultAsync();
            if (route is null)
            {
                return Results.NotFound();
            }

            var tariffRanges = route.TariffSchema.TariffRanges
                                        .OrderBy(tr => tr.SeatClass)
                                        .ThenBy(tr => tr.StartKm)
                                        .ToList();

            return Results.Ok(
                tariffRanges.Select(tr => new
                {
                    tr.StartKm,
                    tr.EndKm,
                    tr.PricePerKm,
                    tr.SeatClass
                })
               );
        });
    }
}
