namespace TrainTicketing.Contracts.DataTransfer;
public record AvailableRoutesFromSpecifiedStationsAndDateDto(string TrainName, TimeSpan startDeparture, TimeSpan endDeparture, int dailyDepartureId, int departureRouteDetailId, int arrivalRouteDetailId);
