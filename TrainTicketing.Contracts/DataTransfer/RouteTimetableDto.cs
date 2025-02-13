namespace TrainTicketing.Contracts.DataTransfer;
public record RouteTimetableDto(string Main, List<string> Cities, List<RouteDepartureAndTimesDto> Timetable);

