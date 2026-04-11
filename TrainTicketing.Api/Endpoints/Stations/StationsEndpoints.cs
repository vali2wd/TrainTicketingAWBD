using Microsoft.EntityFrameworkCore;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.Stations;

public static class StationsEndpoints
{
    public static void AddStationsEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/stations", async (TrainTicketingDbContext dbContext, CancellationToken ctx) =>
        {
            var stations = (await dbContext.Stations.ToListAsync(ctx)).Select(s => new { stationId = s.StationId, stationName = s.StationName });

            return Results.Ok(stations);
        });

        app.MapGet("/stationsPg", async (
            TrainTicketingDbContext dbContext,
            CancellationToken ctx,
            [AsParameters] QueryParameters queryParameters) =>
        {
            var stationsQuery = dbContext.Stations.AsQueryable();
            // Sort by Name
            if (queryParameters.SortByA is not null)
            {
                if (queryParameters.SortByA is true)
                    stationsQuery = stationsQuery.OrderBy(station => station.StationName);
                else
                    stationsQuery = stationsQuery.OrderByDescending(station => station.StationName);
            }
            // Sort by Id.
            if (queryParameters.SortByB is not null)
            {
                if (queryParameters.SortByB is true)
                    stationsQuery = stationsQuery.OrderBy(station => station.StationId);
                else
                    stationsQuery = stationsQuery.OrderByDescending(station => station.StationId);
            }

            stationsQuery = stationsQuery
                             .Skip((queryParameters.PageNumber - 1) * queryParameters.PageSize)
                             .Take(queryParameters.PageSize);

            var stations = (await stationsQuery
                                .ToListAsync(ctx))
                                .Select(s => new { stationId = s.StationId, stationName = s.StationName });

            PaginationResponse<dynamic> response = new(stations, stations.Count(), queryParameters.PageNumber, queryParameters.PageSize);
            return Results.Ok(response);
        });
    }
}
