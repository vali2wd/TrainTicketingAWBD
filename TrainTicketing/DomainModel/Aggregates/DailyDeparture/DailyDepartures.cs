using Microsoft.AspNetCore.Identity;
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

    private List<Reservation> _reservations;

    private DateTime? _modifyDate;

    //private DailyDepartures()
    //{
    //    _reservations = new List<Reservation>();
    //}

    public void AddReservation(
        IdentityUser? user,
        int seatId, int? departureStationRouteDetailId, int? arrivalStationRouteDetailId)
    {
        //to implement logic for train seat availability ... for now leave like this.
        _reservations.Add(Reservation.CreateNew(user, seatId, departureStationRouteDetailId, arrivalStationRouteDetailId));

        _modifyDate = DateTime.Now;

        AddDomainEvent(new ReservationAddedEvent(this.DailyDepartureId));
    }
}

public sealed class DepartureDatesConfigurator : IEntityTypeConfiguration<DailyDepartures>
{
    public void Configure(EntityTypeBuilder<DailyDepartures> builder)
    {
        builder.HasKey(dd => dd.DailyDepartureId);
        builder.HasOne(dd => dd.DepartureSchedule)
            .WithMany()
            .HasForeignKey(dd => dd.DepartureScheduleId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property("_modifyDate").HasColumnName("ModifyDate");
        builder.Property("_versionId").HasColumnName("VersionId").IsConcurrencyToken();

        builder.OwnsMany<Reservation>("_reservations", reservation =>
        {
            reservation.WithOwner().HasForeignKey("DailyDepartureId");
            reservation.Property(r => r.ReservationId).ValueGeneratedNever();
            reservation.HasKey(r => r.ReservationId);
            reservation.HasOne(r => r.User)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);

            reservation.Property(r => r.SeatId)
                .IsRequired();

            reservation.HasOne(r => r.Seat)
                .WithMany()
                .HasForeignKey(r => r.SeatId)
                .OnDelete(DeleteBehavior.Restrict);

            reservation.HasOne(r => r.DepartureStationRouteDetail)
                .WithMany()
                .HasForeignKey(r => r.DepartureStationRouteDetailId)
                .OnDelete(DeleteBehavior.Restrict);

            reservation.HasOne(r => r.ArrivalStationRouteDetail)
                .WithMany()
                .HasForeignKey(r => r.ArrivalStationRouteDetailId)
                .OnDelete(DeleteBehavior.Restrict);
        });

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