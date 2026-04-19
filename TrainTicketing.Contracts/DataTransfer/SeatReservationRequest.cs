using System.ComponentModel.DataAnnotations;

namespace TrainTicketing.Contracts.DataTransfer;

public record SeatReservationRequest(
    [Required(ErrorMessage = "Route departure is mandatory.")] int DailyDepartureId,
    [Required(ErrorMessage = "Departure station is mandatory.")] int DepartureRouteDetailId,
    [Required(ErrorMessage = "Arrival station is mandatory.")] int ArrivalRouteDetailId);
