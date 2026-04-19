using System.ComponentModel.DataAnnotations;

namespace TrainTicketing.Contracts.DataTransfer;
public record QueryParameters(
    bool? SortByA = null,
    bool? SortByB = null,
    [Required(ErrorMessage = "Specify page number")]
    int PageNumber = 1,
    [Range(6, 72)]
    [Required(ErrorMessage = "Specify page size")]
    int PageSize = 10);
