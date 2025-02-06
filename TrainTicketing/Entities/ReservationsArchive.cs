using Microsoft.AspNetCore.Identity;

namespace TrainTicketing.Entities;
internal class ReservationsArchive
{
    public Guid AnnouncementId { get; }

    public string Content { get; set; } = null!;

    public IdentityUser CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}
