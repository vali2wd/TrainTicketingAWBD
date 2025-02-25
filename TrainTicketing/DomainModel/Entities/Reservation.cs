using Microsoft.AspNetCore.Identity;

namespace TrainTicketing.DomainModel.Entities;

public class Reservation
{
    public Guid ReservationId { get; set; }

    public IdentityUser? User { get; set; }

    public int SeatId { get; set; }

    public Seat? Seat { get; set; }

    public int? DepartureStationRouteDetailId { get; set; }

    public RouteDetail? DepartureStationRouteDetail { get; set; }

    public int? ArrivalStationRouteDetailId { get; set; }

    public RouteDetail? ArrivalStationRouteDetail { get; set; }

    private Reservation(IdentityUser? user, int seatId, int? departureStationRouteDetailId, int? arrivalStationRouteDetailId)
    {
        this.ReservationId = Guid.NewGuid();
        this.User = user;
        this.SeatId = seatId;
        this.DepartureStationRouteDetailId = departureStationRouteDetailId;
        this.ArrivalStationRouteDetailId = arrivalStationRouteDetailId;
    }

    /// <summary>
    /// EF Core constructor - NEVER USE
    /// </summary>
    private Reservation() { }

    public static Reservation CreateNew(IdentityUser? User, int seatId, int? departureStationRouteDetailId, int? arrivalStationRouteDetailId)
    {
        return new Reservation(User, seatId, departureStationRouteDetailId, arrivalStationRouteDetailId);
    }
}


//public class ReservationsConfigurator : IEntityTypeConfiguration<Reservation>
//{
//    public void Configure(EntityTypeBuilder<Reservation> builder)
//    {
//        //builder.HasKey(r => r.ReservationId);
//        //builder.HasOne(r => r.User)
//        //    .WithMany()
//        //    .OnDelete(DeleteBehavior.Restrict);

//        //builder.Property(r => r.SeatId)
//        //    .IsRequired();

//        ////builder.HasOne(r => r.DailyDeparture)
//        ////    .WithMany()
//        ////    .HasForeignKey(r => r.DailyDepartureId)
//        ////    .OnDelete(DeleteBehavior.Restrict);

//        //builder.HasOne(r => r.Seat)
//        //    .WithMany()
//        //    .HasForeignKey(r => r.SeatId)
//        //    .OnDelete(DeleteBehavior.Restrict);

//        //builder.HasOne(r => r.DepartureStationRouteDetail)
//        //    .WithMany()
//        //    .HasForeignKey(r => r.DepartureStationRouteDetailId)
//        //    .OnDelete(DeleteBehavior.Restrict);

//        //builder.HasOne(r => r.ArrivalStationRouteDetail)
//        //    .WithMany()
//        //    .HasForeignKey(r => r.ArrivalStationRouteDetailId)
//        //    .OnDelete(DeleteBehavior.Restrict);
//    }
//}