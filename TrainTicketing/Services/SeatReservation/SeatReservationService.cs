using DDD.EF.OptimisticConcurrency.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Entities;
using TrainTicketing.DomainModel.Kernel;
using TrainTicketing.Errors;

namespace TrainTicketing.Services.SeatReservation;

public interface ISeatReservationService
{
    Task<Result<Reservation>> ReserveSeat(SeatReservationRequest seatReservationRequest, IdentityUser user, CancellationToken ctx);
}

public class SeatReservationService : ISeatReservationService
{
    public TrainTicketingDbContext dbContext { get; }

    public UserManager<IdentityUser> userManager { get; }

    public ILogger<SeatReservationService> _logger { get; }

    public SeatReservationService(TrainTicketingDbContext dbContext, UserManager<IdentityUser> userManager, ILogger<SeatReservationService> logger)
    {
        this.dbContext = dbContext;
        this.userManager = userManager;
        _logger = logger;
    }

    public async Task<Result<Reservation>> ReserveSeat(SeatReservationRequest seatReservationRequest, IdentityUser user, CancellationToken ctx)
    {
        var dailyDeparture = await dbContext.DailyDepartures
                                                .Where(dd => dd.DailyDepartureId == seatReservationRequest.DailyDepartureId)
                                                .Include(dd => dd.DepartureSchedule)
                                                    .ThenInclude(ds => ds.Train)
                                                        .ThenInclude(t => t.Seats)
                                                 .Include(dd => dd.DepartureSchedule)
                                                    .ThenInclude(ds => ds.DepartureDetails)
                                                .AsSplitQuery()
                                                .FirstOrDefaultAsync();
        if (dailyDeparture is null)
        {
            return Result<Reservation>.Failure(DepartureErrors.DepartureNotFound);
        }

        var departureRouteDetail = await dbContext.RouteDetails.FirstOrDefaultAsync(rd => rd.Id == seatReservationRequest.DepartureRouteDetailId, ctx);
        var arrivalRouteDetail = await dbContext.RouteDetails.FirstOrDefaultAsync(rd => rd.Id == seatReservationRequest.ArrivalRouteDetailId, ctx);
        if (departureRouteDetail is null)
        {
            return Result<Reservation>.Failure(DepartureErrors.DepartureDetailNotFound);
        }
        if (arrivalRouteDetail is null)
        {
            return Result<Reservation>.Failure(DepartureErrors.ArrivalDetailNotFound);
        }

        var reservation = dailyDeparture.CreateReservation(user, departureRouteDetail, arrivalRouteDetail);

        if (reservation is null)
        {
            return Result<Reservation>.Failure(ReservationErrors.NoSeatsLeft);
        }
        var domainEvents = DomainEventsHelper.GetAllDomainEvents(dailyDeparture);
        if (domainEvents.Any())
        {
            dailyDeparture.IncreaseVersion();
        }

        try
        {
            await dbContext.SaveChangesAsync(ctx);
        }
        catch (DbUpdateConcurrencyException ce)
        {
            _logger.LogWarning(ce, "Concurrency exception occurred while saving changes");
            return Result<Reservation>.Failure(new Error("DomainConcurrencyException", ce.Message));
        }

        return Result<Reservation>.Success(reservation);
    }
}
