using Microsoft.EntityFrameworkCore;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Entities;

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
            int pageNumber = 1,
            int pageSize = 10) =>
        {
            var stations = (await dbContext
                                .Stations
                                .Skip((pageNumber - 1) * pageSize)
                                .Take(pageSize)
                                .ToListAsync(ctx))
                                .Select(s => new { stationId = s.StationId, stationName = s.StationName });

            PaginationResponse<dynamic> response = new(stations, stations.Count(), pageNumber, pageSize);
            return Results.Ok(response);
        });
    }
}
