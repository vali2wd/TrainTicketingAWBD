namespace TrainTicketing.Entities;

public class Train
{
    public Guid TrainId { get; }

    public string TrainName { get; } = null!;

    public TrainType TrainType { get; }

    public int TariffSchemaId { get; }

    public TariffSchema TariffSchema { get; } = null!;

    public ICollection<Seat> Seats { get; } = null!;
}

public enum TrainType
{
    R = 0,
    IR = 1
}