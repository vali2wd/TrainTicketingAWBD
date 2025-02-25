using TrainTicketing.Services.SeatReservation;

namespace TrainTicketing.Api.LifeTimes;

internal static class DependencyInjection
{
    internal static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        services.AddScoped<ISeatReservationService, SeatReservationService>();

        return services;
    }
}
