using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;

public class Train
{
    public Guid TrainId { get; }

    public string TrainName { get; } = null!;

    public TrainType TrainType { get; }

    public ICollection<Seat> Seats { get; } = null!;
}

public class TrainConfiguration : IEntityTypeConfiguration<Train>
{
    public void Configure(EntityTypeBuilder<Train> builder)
    {
        builder.HasKey(t => t.TrainId);

        builder.Property(t => t.TrainName)
            .IsRequired()
            .HasMaxLength(35);

        builder.Property(t => t.TrainType)
            .IsRequired();
        builder.Property(t => t.TrainType)
            .HasConversion<int>();
        builder.HasMany(e => e.Seats)
            .WithOne();
    }
}