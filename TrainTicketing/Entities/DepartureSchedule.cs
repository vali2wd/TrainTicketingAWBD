using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TrainTicketing.Entities;
public class DepartureSchedule
{
    public int DepartureScheduleId { get; set; }

    public Guid RouteId { get; set; }

    public Route Route { get; set; }

    public ICollection<DepartureDetail> DepartureDetails { get; set; }

    public ICollection<Reservation> Reservations { get; set; }

    public bool OutboundMain { get; set; }

    public Guid TrainId { get; set; }

    public Train? Train { get; set; }


}
public class DepatureConfigurator : IEntityTypeConfiguration<DepartureSchedule>
{
    public void Configure(EntityTypeBuilder<DepartureSchedule> builder)
    {
        builder.HasKey(dd => dd.DepartureScheduleId);
        builder.HasOne(d => d.Route)
            .WithMany(r => r.Departures)
            .HasForeignKey(d => d.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(dd => dd.TrainId)
            .IsRequired();
        builder.HasOne(dd => dd.Train)
            .WithMany()
            .HasForeignKey(dd => dd.TrainId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new DepartureSchedule { DepartureScheduleId = 1, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), OutboundMain = true },
            new DepartureSchedule { DepartureScheduleId = 2, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), OutboundMain = false },
            new DepartureSchedule { DepartureScheduleId = 3, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), OutboundMain = true },
            new DepartureSchedule { DepartureScheduleId = 4, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), OutboundMain = false }
            );

    }
}