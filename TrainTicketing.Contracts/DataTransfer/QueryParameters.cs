namespace TrainTicketing.Contracts.DataTransfer;
public record QueryParameters(
    bool? SortByA = null,
    bool? SortByB = null,
    int PageNumber = 1,
    int PageSize = 10);
