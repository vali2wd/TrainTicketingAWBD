using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;
using TrainTicketing.DomainModel.Entities;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Aggregates.DailyDeparture;

public class DailyDeparture : AggregateRootBase
{
    private List<Reservation> _reservations;

    private DateTime? _modifyDate;

    [NotMapped]
    public IReadOnlyList<Reservation> Reservations => _reservations;

    public int DailyDepartureId { get; set; }

    public DateTime DateOfDeparture { get; set; }

    public int DepartureScheduleId { get; set; }

    public DepartureSchedule DepartureSchedule { get; set; } = null!;

    public DailyDeparture()
    {
        _reservations = new List<Reservation>();
    }

    public DailyDeparture(int dailyDepartureId, DateTime dateOfDeparture, int departureScheduleId, DepartureSchedule departureSchedule)
    {
        DailyDepartureId = dailyDepartureId;
        DateOfDeparture = dateOfDeparture;
        DepartureScheduleId = departureScheduleId;
        DepartureSchedule = departureSchedule;
        _reservations = new List<Reservation>();
    }

    /// <summary>
    /// Creates a reservation and adds it to the tracked list of reservations.
    /// </summary>
    /// <param name="user"></param>
    /// <param name="departureStationRouteDetail"></param>
    /// <param name="arrivalStationRouteDetail"></param>
    /// <returns>The reservation created; null if no reservation can be created.</returns>
    public Reservation CreateReservation(
        IdentityUser? user,
        RouteDetail departureStationRouteDetail,
        RouteDetail arrivalStationRouteDetail)
    {
        var trainSeats = this.DepartureSchedule.Train!.Seats.Select(s => s.SeatId).ToHashSet();

        var departureOrderFromMain = departureStationRouteDetail.OrderOfStationFromMain;
        var arrivalOrderdepartureOrderFromMain = arrivalStationRouteDetail.OrderOfStationFromMain;

        var reservationsInConflictWithRequest = this.FindConflictingReservationsWithRequest(departureOrderFromMain, arrivalOrderdepartureOrderFromMain);

        var seatsConflictingWithRequest = reservationsInConflictWithRequest.Select(r => r.SeatId);

        var availableSeats = trainSeats.Except(seatsConflictingWithRequest).ToList();

        if (availableSeats.Count != 0)
        {
            var seatToReserve = availableSeats.First();
            var reservationCreated = Reservation.CreateNew(user, seatToReserve, departureStationRouteDetail.Id, arrivalStationRouteDetail.Id);
            _reservations.Add(reservationCreated);

            _modifyDate = DateTime.Now;

            AddDomainEvent(new ReservationAddedEvent(this.DailyDepartureId));

            return reservationCreated;
        }

        return null;
    }


    /// <summary>
    /// Finds Reservations that have the departure or arrival between the requested departure and arrival, in any way.
    /// If either of the stations is between the requested departure and arrival, the reservation is conflicting.
    /// If the requested departure and arrival are between the reservation departure and arrival, the reservation is conflicting.
    /// </summary>
    /// <param name="departureOrderFromMain"></param>
    /// <param name="arrivalOrderdepartureOrderFromMain"></param>
    /// <returns>The list of reservations that inferr with the specified orders from main station</returns>
    private List<Reservation> FindConflictingReservationsWithRequest(int departureOrderFromMain, int arrivalOrderdepartureOrderFromMain)
    {
        return _reservations
                     .Where(r => (
                                    (departureOrderFromMain < r.ArrivalStationRouteDetail.OrderOfStationFromMain && r.ArrivalStationRouteDetail.OrderOfStationFromMain < arrivalOrderdepartureOrderFromMain) ||
                                    (arrivalOrderdepartureOrderFromMain < r.ArrivalStationRouteDetail.OrderOfStationFromMain && r.ArrivalStationRouteDetail.OrderOfStationFromMain < departureOrderFromMain)
                                 ) ||
                                 (
                                    (departureOrderFromMain < r.ArrivalStationRouteDetail.OrderOfStationFromMain && r.ArrivalStationRouteDetail.OrderOfStationFromMain < arrivalOrderdepartureOrderFromMain) ||
                                    (arrivalOrderdepartureOrderFromMain < r.ArrivalStationRouteDetail.OrderOfStationFromMain && r.ArrivalStationRouteDetail.OrderOfStationFromMain < departureOrderFromMain)
                                 ) ||
                                 (
                                    (departureOrderFromMain < r.DepartureStationRouteDetail.OrderOfStationFromMain && r.DepartureStationRouteDetail.OrderOfStationFromMain < arrivalOrderdepartureOrderFromMain) ||
                                    (arrivalOrderdepartureOrderFromMain < r.DepartureStationRouteDetail.OrderOfStationFromMain && r.DepartureStationRouteDetail.OrderOfStationFromMain < departureOrderFromMain)
                                 )
                     )
                     .ToList();
    }
}

public sealed class DepartureDatesConfigurator : IEntityTypeConfiguration<DailyDeparture>
{
    public void Configure(EntityTypeBuilder<DailyDeparture> builder)
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

            // always load departurestationroutedetail
            reservation.Navigation(r => r.DepartureStationRouteDetail).AutoInclude();
            reservation.Navigation(r => r.ArrivalStationRouteDetail).AutoInclude();
            reservation.Navigation(r => r.Seat).AutoInclude();
        });

        builder.HasData(
            new DailyDeparture { DailyDepartureId = 1, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 1 },
            new DailyDeparture { DailyDepartureId = 2, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 2 },
            new DailyDeparture { DailyDepartureId = 3, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 3 },
            new DailyDeparture { DailyDepartureId = 4, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 4 },
            new DailyDeparture { DailyDepartureId = 5, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 1 },
            new DailyDeparture { DailyDepartureId = 6, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 2 },
            new DailyDeparture { DailyDepartureId = 7, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 3 },
            new DailyDeparture { DailyDepartureId = 8, DateOfDeparture = new DateTime(2025, 12, 2), DepartureScheduleId = 4 },
            new DailyDeparture { DailyDepartureId = 9, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 1 },
            new DailyDeparture { DailyDepartureId = 10, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 2 },
            new DailyDeparture { DailyDepartureId = 11, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 3 },
            new DailyDeparture { DailyDepartureId = 12, DateOfDeparture = new DateTime(2025, 12, 3), DepartureScheduleId = 4 }
            );
    }
}