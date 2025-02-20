using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketing.DomainModel.Aggregates.DailyDeparture;

namespace TrainTicketing.DomainModel.Entities;

public class Reservation
{
    public int ReservationId { get; set; }

    public IdentityUser? User { get; set; }

    public int SeatId { get; set; }

    public bool IsReserved { get; set; }

    public Seat Seat { get; set; }

    ////TODO it should not be departure, but departure date
    //public int DailyDepartureId { get; set; }

    //public DailyDepartures DailyDeparture { get; set; }

    public int? DepartureStationRouteDetailId { get; set; }

    public RouteDetail? DepartureStationRouteDetail { get; set; }

    public int? ArrivalStationRouteDetailId { get; set; }

    public RouteDetail ArrivalStationRouteDetail { get; set; }
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