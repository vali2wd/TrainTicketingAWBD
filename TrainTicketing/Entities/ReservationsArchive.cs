using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TrainTicketing.Entities;
public class ReservationsArchive
{
    public Guid AnnouncementId { get; }

    public string Content { get; set; } = null!;

    public IdentityUser CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}

public class ReservationsArchiveConfigurator : IEntityTypeConfiguration<Reservation>
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