using TrainTicketing.DomainModel.Kernel;

public class Result<T>
{
    private Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None ||
            !isSuccess && error == Error.None)
        {
            throw new ArgumentException("Invalid error", nameof(error));
        }

        Data = default(T);
        IsSuccess = isSuccess;
        Error = error;
    }

    private Result(bool isSuccess, T data, Error error)
    {
        if (isSuccess && error != Error.None ||
            !isSuccess && error == Error.None)
        {
            throw new ArgumentException("Invalid error", nameof(error));
        }
        this.Data = data;
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }

    public bool IsFailure => !IsSuccess;

    public T Data { get; set; }

    public Error Error { get; }

    public static Result<T> Success(T data) => new(true, data, Error.None);

    public static Result<T> Failure(Error error) => new(false, error);
}