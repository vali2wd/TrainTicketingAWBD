using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Entities;
public class TariffSchema : Entity
{
    public int TariffSchemaId { get; set; }

    public string TariffSchemaName { get; set; } = null!;

    public ICollection<TariffRanges> TariffRanges { get; set; } = [];
}

public class TariffSchemaConfigurator : IEntityTypeConfiguration<TariffSchema>
{
    void IEntityTypeConfiguration<TariffSchema>.Configure(EntityTypeBuilder<TariffSchema> builder)
    {
        builder.HasKey(e => e.TariffSchemaId);

        builder.Property(e => e.TariffSchemaName)
            .IsRequired()
            .HasMaxLength(50);


        builder.HasData(
            new TariffSchema { TariffSchemaId = 1, TariffSchemaName = "Standard" });
    }
}