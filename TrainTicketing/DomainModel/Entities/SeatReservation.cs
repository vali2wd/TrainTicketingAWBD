using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Entities;
public class SeatReservation : Entity
{
    public int Id { get; set; }

    public int SeatId { get; set; }

    public Seat? Seat { get; set; }

    public int ReservationId { get; set; }

    public Reservation? Reservation { get; set; }
}
