namespace TrainTicketing.Contracts.DataTransfer;

public record ReservationReportDto(
    Guid ReservationId,
    decimal Price,
    DateTime ReservationDate,
    int? DepartureStationDetailId,
    int? ArrivalStationDetailId
);
