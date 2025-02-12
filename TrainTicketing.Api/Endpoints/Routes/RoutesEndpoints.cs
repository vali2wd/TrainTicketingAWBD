using Microsoft.EntityFrameworkCore;
using TrainTicketing.Database;
using TrainTicketing.ValueObjects;

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
    }
}
