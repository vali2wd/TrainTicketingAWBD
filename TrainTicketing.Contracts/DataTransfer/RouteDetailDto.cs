namespace TrainTicketing.Contracts.DataTransfer;
public record DepartureDetailsEachStationDto(string StationName, TimeSpan DepartureTime, decimal KilometersFromOrigin);
