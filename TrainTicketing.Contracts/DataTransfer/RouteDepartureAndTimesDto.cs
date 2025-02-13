namespace TrainTicketing.Contracts.DataTransfer;
public record RouteDepartureAndTimesDto(bool OutbountMain, string TrainName, List<TimeSpan> DepartureTimes);

