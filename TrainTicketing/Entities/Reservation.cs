using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Reservation
{
    public int Id { get; set; }

    public IdentityUser User { get; set; } 

    public Guid TrainId { get; set; }

    public Train Train {  get; set; }

    public ICollection<Seat> Seats { get; set; } = [];

    public int RouteId { get; set; }

    public Route Route { get; set; }
}


public class ReservationsConfigurator : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasKey(r => r.Id);
        builder.HasOne(r => r.User)
            .WithMany()
            .HasForeignKey(r => r.User.Id)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(r => r.Train)
            .WithMany()
            .HasForeignKey(r => r.TrainId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(r => r.Seats)
            .WithMany();
        builder.HasOne(r => r.Route)
            .WithMany()
            .HasForeignKey(r => r.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}