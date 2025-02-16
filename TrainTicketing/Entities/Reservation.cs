using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Reservation
{
    public int ReservationId { get; set; }

    public IdentityUser User { get; set; }

    public int SeatId { get; set; }
    
    public Seat Seat { get; set; }

    public int DepartureId { get; set; }

    public Departure Departure { get; set; }
}


public class ReservationsConfigurator : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasKey(r => r.ReservationId);
        builder.HasOne(r => r.User)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.Departure)
            .WithMany(d => d.Reservations)
            .HasForeignKey(r => r.DepartureId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.Seat)
            .WithMany()
            .HasForeignKey(r => r.SeatId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}