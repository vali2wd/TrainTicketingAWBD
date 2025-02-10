using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Reservation
{
    public int ReservationId { get; set; }

    public IdentityUser User { get; set; }

    public Guid TrainId { get; set; }

    public Train Train { get; set; }

    public List<SeatReservation> SeatReservations { get; } = [];

    public Guid RouteId { get; set; }

    public Route Route { get; set; }
}


public class ReservationsConfigurator : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasKey(r => r.ReservationId);
        builder.HasOne(r => r.User)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(r => r.Train)
            .WithMany()
            .HasForeignKey(r => r.TrainId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.Route)
            .WithMany()
            .HasForeignKey(r => r.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}