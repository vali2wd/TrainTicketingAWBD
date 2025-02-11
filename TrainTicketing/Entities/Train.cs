using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;

public class Train
{
    public Guid TrainId { get; set; }

    public string TrainName { get; set;  } = null!;

    public TrainType TrainType { get; set; }

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
        //builder.HasMany(e => e.Seats)
        //    .WithOne(e => e.Train);

        builder.HasData(
            new Train { TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), TrainName = "Express A", TrainType = TrainType.IR },
            new Train { TrainId = Guid.Parse("98407e8c-f851-4afc-ae75-061d9f563e9c"), TrainName = "Regional B", TrainType = TrainType.R },
            new Train { TrainId = Guid.Parse("8be4b93d-68ab-4d5d-aa7a-73264548117b"), TrainName = "Superfast C", TrainType = TrainType.IR },
            new Train { TrainId = Guid.Parse("5e6adc1c-5279-47f9-b6e5-dccc00e02350"), TrainName = "Local D", TrainType = TrainType.R },
            new Train { TrainId = Guid.Parse("2266d573-e2fe-4d32-b45d-6a9a04d84bcb"), TrainName = "Nightliner E", TrainType = TrainType.IR }
        );
    }
}