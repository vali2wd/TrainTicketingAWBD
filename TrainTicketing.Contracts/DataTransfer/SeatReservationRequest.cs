namespace TrainTicketing.Contracts.DataTransfer;

public record SeatReservationRequest(int DailyDepartureId, int DepartureRouteDetailId, int ArrivalRouteDetailId);
