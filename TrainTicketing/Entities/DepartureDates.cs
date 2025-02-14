using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class DepartureDates
{
    public int DepartureDateId { get; set; }

    public DateTime DateOfDeparture { get; set; }

    public int DepartureId { get; set; }

    public Departure Departure { get; set; } = null!;
}

public class DepartureDatesConfigurator : IEntityTypeConfiguration<DepartureDates>
{
    public void Configure(EntityTypeBuilder<DepartureDates> builder)
    {
        builder.HasKey(dd => dd.DepartureDateId);
        builder.HasOne(dd => dd.Departure)
            .WithMany()
            .HasForeignKey(dd => dd.DepartureId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasData(
            new DepartureDates { DepartureDateId = 1, DateOfDeparture = new DateTime(2025, 12, 1), DepartureId = 1 },
            new DepartureDates { DepartureDateId = 2, DateOfDeparture = new DateTime(2025, 12, 1), DepartureId = 2 },
            new DepartureDates { DepartureDateId = 3, DateOfDeparture = new DateTime(2025, 12, 1), DepartureId = 3 },
            new DepartureDates { DepartureDateId = 4, DateOfDeparture = new DateTime(2025, 12, 1), DepartureId = 4 },
            new DepartureDates { DepartureDateId = 5, DateOfDeparture = new DateTime(2025, 12, 2), DepartureId = 1 },
            new DepartureDates { DepartureDateId = 6, DateOfDeparture = new DateTime(2025, 12, 2), DepartureId = 2 },
            new DepartureDates { DepartureDateId = 7, DateOfDeparture = new DateTime(2025, 12, 2), DepartureId = 3 },
            new DepartureDates { DepartureDateId = 8, DateOfDeparture = new DateTime(2025, 12, 2), DepartureId = 4 },
            new DepartureDates { DepartureDateId = 9, DateOfDeparture = new DateTime(2025, 12, 3), DepartureId = 1 },
            new DepartureDates { DepartureDateId = 10, DateOfDeparture = new DateTime(2025, 12, 3), DepartureId = 2 },
            new DepartureDates { DepartureDateId = 11, DateOfDeparture = new DateTime(2025, 12, 3), DepartureId = 3 },
            new DepartureDates { DepartureDateId = 12, DateOfDeparture = new DateTime(2025, 12, 3), DepartureId = 4 }
            );
    }
}