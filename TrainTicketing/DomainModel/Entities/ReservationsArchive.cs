using Microsoft.AspNetCore.Identity;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Entities;
public class ReservationsArchive : Entity
{
    public int ReservationId { get; set; }

    public Guid AnnouncementId { get; }

    public string Content { get; set; } = null!;

    public IdentityUser CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}

//public class ReservationsArchiveConfigurator : IEntityTypeConfiguration<Reservation>
//{
//    public void Configure(EntityTypeBuilder<ReservationsArchive> builder)
//    {
//        builder.HasKey(r => r.ReservationId);
//        builder.HasOne(r => r.User)
//            .WithMany()
//            .OnDelete(DeleteBehavior.Restrict);
//        builder.HasOne(r => r.Train)
//            .WithMany()
//            .HasForeignKey(r => r.TrainId)
//            .OnDelete(DeleteBehavior.Restrict);
//        //builder.HasMany(r => r.Seats)
//            //.WithMany();
//        builder.HasOne(r => r.Route)
//            .WithMany()
//            .HasForeignKey(r => r.RouteId)
//            .OnDelete(DeleteBehavior.Restrict);
//    }
//}