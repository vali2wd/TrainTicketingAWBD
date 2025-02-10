namespace TrainTicketing.Entities;
public class SeatReservation
{
    public int Id { get; set; }

    public int SeatId { get; set; }

    public Seat? Seat { get; set; }

    public int ReservationId { get; set; }

    public Reservation? Reservation { get; set; }
}
