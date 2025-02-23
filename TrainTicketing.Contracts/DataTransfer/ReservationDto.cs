namespace TrainTicketing.Contracts.DataTransfer;
public record ReservationDto(Guid ReservationId, string SeatCode, string departureStationName, string arrivalStationName);

