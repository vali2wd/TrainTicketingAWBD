using Microsoft.EntityFrameworkCore;
using TrainTicketing.Database;

namespace TrainTicketing.Api.Endpoints.RouteReservation;

public static class RouteReservationEndpoints
{
    public static void AddRouteReservationEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/reserve-seat", async(Guid userId, int departureDateId, int departureRouteDetailId, int arrivalRouteDetailId, TrainTicketingDbContext dbContext, ILogger<Program> _logger, CancellationToken ctx) =>
        {
            // SAU care sunt rezervate dar n-au arrival si departure intre ale melee
        //    var reservationsForDayDeparture =   await dbContext.Reservations
        //                                                        .Where(r => r.DailyDepartureId == departureDateId && 
        //                                                                    r.DepartureStationRouteDetailId == departureRouteDetailId &&
        //                                                                    r.ArrivalStationRouteDetailId == arrivalRouteDetailId)
        //                                                        .Include(r => r.DepartureStationRouteDetail)
        //                                                        .Include(r => r.ArrivalStationRouteDetail)
        //                                                        .ToListAsync(ctx);
            
        //    try
        //    {
        //        var firstAvailableReservation = reservationsForDayDeparture.First(r => r.IsReserved == false);
        //        firstAvailableReservation.IsReserved = true;
        //        await dbContext.SaveChangesAsync(ctx);
        //    }
        //    catch(DbUpdateConcurrencyException ex)
        //    {
        //        _logger.LogError(ex, "Concurrency exception occurred on seat reservation");
        //        Results.Conflict("Conflict ocurred on seat reservation. Try reserving again");
        //    }
        //    catch (OperationCanceledException)
        //    {
        //        _logger.LogInformation("Seat reservation was cancelled");
        //    }

        //    return Results.CreatedAtRoute("reserve-seat", new { userId, departureDateId, departureRouteDetailId, arrivalRouteDetailId });
        //});

        //app.MapGet("/get-reservation", async (int reservationId, TrainTicketingDbContext dbContext, CancellationToken ctx) =>
        //{
        //    var reservation = await dbContext.Reservations
        //                                .Where(r => r.ReservationId == reservationId)
        //                                .Include(r=> r.Seat)
        //                                .Include(r => r.DailyDeparture)
        //                                    .ThenInclude(r => r.DepartureSchedule)
        //                                        .ThenInclude(ds => ds.DepartureDetails)
        //                                .Include(r => r.ArrivalStationRouteDetail)
        //                                    .ThenInclude(r => r.Station)
        //                                .Include(r => r.DepartureStationRouteDetail)
        //                                    .ThenInclude(r => r.Station)
        //                                .FirstOrDefaultAsync(ctx);

        //    if (reservation is null)
        //    {
        //        return Results.NotFound("Reservation not found");
        //    }

        //    var departureTimeSpan = await dbContext.DepartureDetails
        //                                            .Where(dd => dd.RouteDetailId == reservation.DepartureStationRouteDetailId &&
        //                                                   dd.DepartureId == reservation.DailyDeparture.DepartureScheduleId)
        //                                            .Select(dd => dd.DepatureTime)
        //                                            .FirstOrDefaultAsync();
        //    var arrivalTimeSpan = await dbContext.DepartureDetails
        //                                            .Where(dd => dd.RouteDetailId == reservation.ArrivalStationRouteDetailId &&
        //                                                   dd.DepartureId == reservation.DailyDeparture.DepartureScheduleId)
        //                                            .Select(dd => dd.DepatureTime)
        //                                            .FirstOrDefaultAsync();
        //    return Results.Ok(new { Seat = reservation.Seat.SeatCode,
        //                            SeatClass = reservation.Seat.SeatCode,
        //                            Departure = reservation.DepartureStationRouteDetail.Station.StationName,
        //                            Arrival = reservation.ArrivalStationRouteDetail.Station.StationName,
        //                            DepartureTime = reservation.DailyDeparture.DateOfDeparture + departureTimeSpan,
        //                            ArrivalTime = reservation.DailyDeparture.DateOfDeparture + arrivalTimeSpan
        //    });
        });
    }
}


