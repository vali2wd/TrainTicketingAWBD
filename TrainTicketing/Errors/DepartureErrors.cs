using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.Errors;
public static class DepartureErrors
{
    public static readonly Error DepartureNotFound = new Error(
        "DepartureErrors.DepartureNotFound", "Can't find departure");

    public static readonly Error DepartureDetailNotFound = new Error(
        "DepartureErrors.DepartureDetailNotFound", "Can't find departure detail");

    public static readonly Error ArrivalDetailNotFound = new Error(
    "DepartureErrors.ArrivalDetailNotFound", "Can't find arrival detail");

    public static readonly Error NoSeats = new Error(
        "DepartureErrors.NoSeats", "No seats available");
}
