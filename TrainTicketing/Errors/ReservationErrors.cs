using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.Errors;
public static class ReservationErrors
{
    public static readonly Error NoSeatsLeft = new Error(
        "ReservationErrors.NoSeatsLeft", "Cannot insert a new reservation due to insufficient seats.");
}
