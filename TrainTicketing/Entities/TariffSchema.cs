using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class TariffSchema
{
    public int TariffId { get; set;  }

    public string TariffSchemaName { get; set; } = null!;

    public ICollection<TariffRanges> TariffRanges { get; set; } = [];
}

public class TariffSchemaConfigurator : IEntityTypeConfiguration<TariffSchema>
{
    void IEntityTypeConfiguration<TariffSchema>.Configure(EntityTypeBuilder<TariffSchema> builder)
    {
        builder.HasKey(e => e.TariffId);

        builder.Property(e => e.TariffSchemaName)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasMany(e => e.TariffRanges)
            .WithOne();

        builder.HasData(
            new TariffSchema { TariffId = 1, TariffSchemaName = "Standard" });
    }
}