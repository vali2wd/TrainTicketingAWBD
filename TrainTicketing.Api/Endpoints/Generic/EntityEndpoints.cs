using Microsoft.EntityFrameworkCore;

namespace TrainTicketing.Api.Endpoints.Generic;

public static class EntityEndpoints
{
    // We add TContext to the generic parameters
    public static void MapGenericEndpoints<T, TContext>(this IEndpointRouteBuilder routes, string pattern)
        where T : class
        where TContext : DbContext
    {
        var group = routes.MapGroup(pattern);

        // Now we inject TContext instead of the base DbContext
        group.MapGet("/", async (TContext db) =>
            await db.Set<T>().ToListAsync());

        group.MapGet("/{id}", async (TContext db, int id) =>
            await db.Set<T>().FindAsync(id) is T entity ? Results.Ok(entity) : Results.NotFound());

        group.MapPost("/", async (TContext db, T entity) =>
        {
            db.Set<T>().Add(entity);
            await db.SaveChangesAsync();
            return Results.Created(); // Note: Simplified for the example
        }).RequireAuthorization("WorkerPolicy")
        .WithName($"PostObservation{typeof(T)}");

        group.MapDelete("/{id}", async (TContext db, int id) =>
        {
            var entity = await db.Set<T>().FindAsync(id);
            if (entity is null) return Results.NotFound();

            db.Set<T>().Remove(entity);
            await db.SaveChangesAsync();
            return Results.NoContent();
        }).RequireAuthorization("WorkerPolicy")
        .WithName($"DeleteById{typeof(T)}"); ;
    }
}