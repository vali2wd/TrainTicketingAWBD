namespace TrainTicketing.Entities;
public class TariffSchema
{
    public int TariffId { get; }

    public string TariffSchemaName { get; } = null!;

    public ICollection<TariffRanges> TariffRanges { get; set; } = [];
}
