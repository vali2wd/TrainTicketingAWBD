using Microsoft.EntityFrameworkCore;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.Stations;

public static class StationsEndpoints
{
    public static void AddStationsEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/stations", async (TrainTicketingDbContext dbContext, CancellationToken ctx) => {
            var stations = await dbContext.Stations.ToListAsync(ctx);
        });
    }
}
