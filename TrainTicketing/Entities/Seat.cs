namespace TrainTicketing.Entities;
public class Seat
{
    public int Id { get; }

    public string SeatCode { get; } = null!;

    public SeatClass SeatClass{ get; set; }
}

public enum SeatClass
{
    First = 1,
    Second = 2,
}
