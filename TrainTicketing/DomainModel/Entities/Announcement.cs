using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Entities;

public class Announcement : Entity
{
    public Guid AnnouncementId { get; }

    public string Content { get; set; } = null!;

    public IdentityUser CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }
}

public class AnnouncementConfigurator : IEntityTypeConfiguration<Announcement>
{
    public void Configure(EntityTypeBuilder<Announcement> builder)
    {
        builder.HasKey(a => a.AnnouncementId);
        builder.Property(a => a.Content)
            .IsRequired()
            .HasMaxLength(255);
        builder.HasOne(a => a.CreatedBy)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);
        builder.Property(e => e.CreatedAt).IsRequired();
    }
}