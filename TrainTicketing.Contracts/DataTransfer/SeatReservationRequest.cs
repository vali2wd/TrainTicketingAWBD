namespace TrainTicketing.Api.Endpoints.RouteReservation;

public record SeatReservationRequest(int DailyDepartureId, int DepartureRouteDetailId, int ArrivalRouteDetailId);
