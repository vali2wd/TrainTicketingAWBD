using System.ComponentModel.DataAnnotations;

namespace TrainTicketing.Contracts.DataTransfer;

public class PaginationResponse<T>
{
    public IEnumerable<T> Data { get; }

    [Required(ErrorMessage = "Specify page number")]
    public int PageNumber { get; }

    [Range(6, 72)]
    [Required(ErrorMessage = "Specify page size")]
    public int PageSize { get; }
    
    public int TotalPages { get; }
    
    public int TotalCount { get; }
    
    public bool HasPreviousPage => PageNumber > 1;
    
    public bool HasNextPage => PageNumber < TotalPages;

    public PaginationResponse(IEnumerable<T> data, int count, int pageNumber, int pageSize)
    {
        this.PageNumber = pageNumber;
        this.PageSize = pageSize;
        this.TotalCount = count;
        this.TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        this.Data = data;
    }

    public static PaginationResponse<T> Create(IEnumerable<T> data, int count, int pageNumber, int pageSize)
    {
        return new PaginationResponse<T>(data, count, pageNumber, pageSize);
    }
}
