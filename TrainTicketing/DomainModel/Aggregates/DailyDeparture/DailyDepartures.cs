using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketing.DomainModel.Entities;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Aggregates.DailyDeparture;
public class DailyDepartures : AggregateRootBase
{
    public int DailyDepartureId { get; set; }

    public DateTime DateOfDeparture { get; set; }

    public int DepartureScheduleId { get; set; }

    public DepartureSchedule DepartureSchedule { get; set; } = null!;
}

public class DepartureDatesConfigurator : IEntityTypeConfiguration<DailyDepartures>
{
    public void Configure(EntityTypeBuilder<DailyDepartures> builder)
    {
        builder.HasKey(dd => dd.DailyDepartureId);
        builder.HasOne(dd => dd.DepartureSchedule)
            .WithMany()
            .HasForeignKey(dd => dd.DepartureScheduleId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasData(
            new DailyDepartures { DailyDepartureId = 1, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 1 },
            new DailyDepartures { DailyDepartureId = 2, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 2 },
            new DailyDepartures { DailyDepartureId = 3, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 3 },
            new DailyDepartures { DailyDepartureId = 4, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 4 },
            new DailyDepartures { DailyDepartureId = 5, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 1 },
            new DailyDepartures { DailyDepartureId = 6, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 2 },
            new DailyDepartures { DailyDepartureId = 7, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 3 },
            new DailyDepartures { DailyDepartureId = 8, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 4 },
            new DailyDepartures { DailyDepartureId = 9, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 1 },
            new DailyDepartures { DailyDepartureId = 10, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 2 },
            new DailyDepartures { DailyDepartureId = 11, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 3 },
            new DailyDepartures { DailyDepartureId = 12, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 4 }
            );
    }
}