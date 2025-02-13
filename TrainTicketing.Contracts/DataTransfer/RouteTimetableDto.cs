namespace TrainTicketing.Contracts.DataTransfer;
public record RouteTimetableDto(List<string> Cities, List<RouteDepartureAndTimesDto> Timetable);

