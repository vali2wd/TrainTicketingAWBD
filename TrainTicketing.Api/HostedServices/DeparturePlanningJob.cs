using Microsoft.EntityFrameworkCore;
using TrainTicketing.Database;
using TrainTicketing.Entities;

namespace TrainTicketing.Api.HostedServices;

public class DeparturePlanningJob : BackgroundService
{
    public IServiceProvider Services { get; }

    public ILogger<DeparturePlanningJob> _logger { get; }

    public DeparturePlanningJob(IServiceProvider services, ILogger<DeparturePlanningJob> _logger)
    {
        Services = services;
        this._logger = _logger;
    }

    // should be logging here!!
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(15));
        while (!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken))
        {
            await AddAllDepartures(7, stoppingToken);
        }
    }

    public async Task AddAllDepartures(int daysFromToday, CancellationToken cancellationToken)
    {
        using var scope = this.Services.CreateScope();

        var dbContext = scope.ServiceProvider.GetRequiredService<TrainTicketingDbContext>();

        var departureIds = await dbContext.Departures.Select(d => d.DepartureId).ToListAsync();

        var futureDate = DateTime.UtcNow.AddDays(daysFromToday);

        foreach (var departureId in departureIds)
        {
            dbContext.DepartureDates.Add(new DepartureDates
            {
                DateOfDeparture = futureDate,
                DepartureId = departureId
            });
        }
        _logger.LogInformation("Added departure dates for {0} departures", departureIds.Count);
        //await dbContext.SaveChangesAsync(cancellationToken);
    }
    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        await base.StopAsync(stoppingToken);
    }
}

