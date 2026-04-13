namespace TrainTicketing.Contracts.DataTransfer;

public record ReservationReportDto(
    Guid ReservationId,
    string TrainName,
    decimal Price,
    DateTime ReservationDate,
    string DepartureStation
);
