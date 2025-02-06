namespace TrainTicketing.Entities;
public class TariffRanges
{
    public int TariffRangeId { get; set; }

    public decimal StartKm { get; set; }

    public decimal EndKm { get; set; }

    public decimal PricePerKm { get; set; }

    public SeatClass SeatClass { get; set; }
}
