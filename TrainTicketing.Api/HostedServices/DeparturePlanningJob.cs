using Microsoft.EntityFrameworkCore;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Aggregates.DailyDeparture;

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

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        using PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromHours(24));
        _logger.LogInformation("Departure Planning Job is starting with time period of {0}", timer.Period);
        while (!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken))
        {
            await this.AddAllDepartures(7, stoppingToken);
        }
    }

    public async Task AddAllDepartures(int daysFromToday, CancellationToken cancellationToken)
    {
        using var scope = this.Services.CreateScope();

        var dbContext = scope.ServiceProvider.GetRequiredService<TrainTicketingDbContext>();

        var trains = await dbContext.Trains.Include(t => t.Seats).AsNoTracking().ToListAsync();
        var departureIds = await dbContext.DepartureSchedules.AsNoTracking().Select(d => d.DepartureScheduleId).ToListAsync();

        var futureDate = DateTime.UtcNow.AddDays(daysFromToday);

        _logger.LogInformation("Identified {0} routes. Begin to add them with {1}.", departureIds.Count, futureDate);

        foreach (var departureId in departureIds)
        {
            dbContext.DailyDepartures.Add(new DailyDeparture
            {
                DateOfDeparture = futureDate,
                DepartureScheduleId = departureId
            });
        }
        try
        {
            await dbContext.SaveChangesAsync(cancellationToken);
            _logger.LogInformation("Successfully added {0} departures with date {1}", departureIds.Count, futureDate);
        }
        catch (OperationCanceledException oce)
        {
            _logger.LogInformation("Could not seed {0} departures with date {1}. {2}", departureIds.Count, futureDate, oce.Message);
        }
    }
    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Departure Planning Job is stopping.");
        await base.StopAsync(stoppingToken);
    }
}

