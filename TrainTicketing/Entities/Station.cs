using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Station
{
    public Guid StationId { get; }

    public string StationName { get; } = null!;
}

public class StationConfigurator : IEntityTypeConfiguration<Station>
{
    public void Configure(EntityTypeBuilder<Station> builder)
    {
        builder.HasKey(s => s.StationId);
        builder.Property(s => s.StationName)
            .IsRequired()
            .HasMaxLength(35);
    }
}
