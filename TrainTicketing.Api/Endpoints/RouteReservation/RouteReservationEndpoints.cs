using Azure.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TrainTicketing.Contracts.DataTransfer;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Entities;
using TrainTicketing.Services.SeatReservation;

namespace TrainTicketing.Api.Endpoints.RouteReservation;
//var dailyDeparture = await dbContext.DailyDepartures
//                                        .Where(dd => dd.DailyDepartureId == seatReservationRequest.DailyDepartureId)
//                                        .Include(dd => dd.DepartureSchedule)
//                                            .ThenInclude(ds => ds.Train)
//                                                .ThenInclude(t => t.Seats)
//                                         .Include(dd => dd.DepartureSchedule)
//                                            .ThenInclude(ds => ds.DepartureDetails)
//                                        .AsSplitQuery()
//                                        .FirstAsync();
//if (dailyDeparture is null)
//{
//    return Results.NotFound("Daily departure not found");
//}

//var departureRouteDetail = await dbContext.RouteDetails.FirstOrDefaultAsync(rd => rd.Id == seatReservationRequest.DepartureRouteDetailId, ctx);
//var arrivalRouteDetail = await dbContext.RouteDetails.FirstOrDefaultAsync(rd => rd.Id == seatReservationRequest.ArrivalRouteDetailId, ctx);
//if (departureRouteDetail is null)
//{
//    return Results.NotFound("Departure route detail not found");
//}
//if (arrivalRouteDetail is null)
//{
//    return Results.NotFound("Arrival route detail not found");
//}

//var reservation = dailyDeparture.CreateReservation(user, departureRouteDetail, arrivalRouteDetail);

//if (reservation is null)
//{
//    return Results.BadRequest("No available seats for reservation");
//}

//var domainEvents = DomainEventsHelper.GetAllDomainEvents(dailyDeparture);
//if (domainEvents.Any())
//{
//    dailyDeparture.IncreaseVersion();
//}

//try
//{
//    await dbContext.SaveChangesAsync(ctx);
//}
//catch (DbUpdateConcurrencyException ce)
//{
//    return Results.Conflict($"Error occurred on seat reservation. Try reserving again!\n{ce.Message}");
//}

// Fix
public static class RouteReservationEndpoints
{
    public static void AddRouteReservationEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapPost("/reserve-seat",
            async (SeatReservationRequest seatReservationRequest,
                  ISeatReservationService seatReservationService,
                  IHttpClientFactory httpClientFactory,
                  UserManager<IdentityUser> userManager,
                  HttpContext httpContext,
                  ILogger<Program> _logger,
                  CancellationToken ctx) =>
            {
                var user = await userManager.GetUserAsync(httpContext.User);
                if (user == null)
                {
                    return Results.Unauthorized();
                }

                var reservationResult = await seatReservationService.ReserveSeatAsync(seatReservationRequest, user, ctx);

                if (reservationResult.IsFailure)
                {
                    return Results.BadRequest(reservationResult.Error);
                }

                SendReservationEmail(httpClientFactory, _logger, user, reservationResult);
                GatherTicketingDataForBI(httpClientFactory, reservationResult);

                return Results.CreatedAtRoute("GetSeatReservationById", new { reservationId = reservationResult.Data.ReservationId });
            }).RequireAuthorization("ClientPolicy");

        app.MapGet("seat-reservations", async (
                  UserManager<IdentityUser> userManager,
                  HttpContext httpContext,
                  TrainTicketingDbContext dbContext,
                  CancellationToken ctx) =>
        {
            var user = await userManager.GetUserAsync(httpContext.User);
            if (user == null)
            {
                return Results.Unauthorized();
            }

            // Auto-included seat, arrival, departure.
            var now = DateTime.Now;
            var reservations = (await dbContext.DailyDepartures
                                        .Where(dd => dd.DateOfDeparture >= now - TimeSpan.FromDays(90)).ToListAsync())
                                        .SelectMany(dd => dd.Reservations)
                                        .Where(r => r.User!.Id == user.Id)
                                        .ToList();

            var stations = await dbContext.Stations.ToListAsync();

            var reservationsResponse = reservations.Select(r => new ReservationDto(
                r.ReservationId,
                r.Seat!.SeatCode,
                stations.FirstOrDefault(s => s.StationId == r.DepartureStationRouteDetail!.Station!.StationId)!.StationName,
                stations.FirstOrDefault(s => s.StationId == r.ArrivalStationRouteDetail!.Station!.StationId)!.StationName))
            .ToList();

            return Results.Ok(reservationsResponse);
        }).RequireAuthorization("ClientPolicy"); ;

        app.MapGet("seat-reservation", async (
                  Guid reservationId,
                  TrainTicketingDbContext dbContext,
                  UserManager<IdentityUser> userManager,
                  HttpContext httpContext,
                  ILogger<Program> _logger,
                  CancellationToken ctx) =>
        {
            var user = await userManager.GetUserAsync(httpContext.User);
            if (user == null)
            {
                return Results.Unauthorized();
            }

            var now = DateTime.Now;
            var reservationById = (await dbContext.DailyDepartures.Where(dd => dd.DateOfDeparture >= now - TimeSpan.FromDays(90)).ToListAsync())
                                        .SelectMany(dd => dd.Reservations)
                                        .FirstOrDefault(r => r.ReservationId == reservationId);
            if (reservationById is null)
            {
                return Results.NotFound("Reservation not found");
            }

            var departureStationName = (await dbContext.Stations
                                                .FirstOrDefaultAsync(s => s.StationId == reservationById.DepartureStationRouteDetail!.StationId))!
                                        .StationName;
            var arrivalStationName = (await dbContext.Stations
                                    .FirstOrDefaultAsync(s => s.StationId == reservationById.ArrivalStationRouteDetail!.StationId))!
                            .StationName;
            var seatCode = reservationById.Seat!.SeatCode;

            if (reservationById.User!.Id != user.Id)
            {
                return Results.Forbid();
            }

            var reservationResponse = new ReservationDto(
                reservationById.ReservationId,
                seatCode,
                departureStationName,
                arrivalStationName);

            return Results.Ok(reservationResponse);
        }).RequireAuthorization("ClientPolicy")
        .WithName("GetSeatReservationById");
    }

    private static async void GatherTicketingDataForBI(IHttpClientFactory httpClientFactory, Result<Reservation> reservationResult)
    {
        var reportingClient = httpClientFactory.CreateClient("ReportingClient");

        var reportData = new ReservationReportDto(
            reservationResult.Data.ReservationId,
            45.50m,     // Your tariff logic
            DateTime.Now,
            reservationResult.Data.DepartureStationRouteDetailId,
            reservationResult.Data.ArrivalStationRouteDetailId
        );

        // Pushing to the reporting microservice
        await reportingClient.PostAsJsonAsync("/reports/collect", reportData);
    }

    private static async void SendReservationEmail(IHttpClientFactory httpClientFactory, ILogger<Program> _logger, IdentityUser user, Result<DomainModel.Entities.Reservation> reservationResult)
    {
        try
        {
            var client = httpClientFactory.CreateClient("NotificationClient");

            var emailRequest = new SendEmailRequest(
                user.Email!,
                "Train Ticket Confirmed",
                $"Hello {user.UserName}, your seat {reservationResult.Data.SeatId} is reserved!",
                reservationResult.Data.ReservationId
            );
            await client.PostAsJsonAsync("/emails/send", emailRequest);
        }
        catch (Exception ex)
        {
            _logger.LogWarning("Could not send notification: {Message}", ex.Message);
        }
    }
}


