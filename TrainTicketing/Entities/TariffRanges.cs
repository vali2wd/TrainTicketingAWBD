using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class TariffRanges
{
    public int TariffRangeId { get; set; }

    public decimal StartKm { get; set; }

    public decimal EndKm { get; set; }

    public decimal PricePerKm { get; set; }

    public SeatClass SeatClass { get; set; }
}

public class TariffRangesConfigurator : IEntityTypeConfiguration<TariffRanges>
{
    public void Configure(EntityTypeBuilder<TariffRanges> builder)
    {
        builder.HasKey(t => t.TariffRangeId);
        builder.Property(t => t.StartKm)
            .IsRequired()
            .HasPrecision(4,1);
        builder.Property(t => t.EndKm)
            .IsRequired()
            .HasPrecision(4, 1);
        builder.Property(t => t.PricePerKm)
            .IsRequired()
            .HasPrecision(2, 2);
        builder.Property(t => t.SeatClass)
            .IsRequired();
    }
}