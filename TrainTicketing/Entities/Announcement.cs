using Microsoft.AspNetCore.Identity;

namespace TrainTicketing.Entities;

public class Announcement
{
    public Guid AnnouncementId{ get; }

    public string Content { get; set; } = null!;
    
    public IdentityUser CreatedBy { get; set; }

    public DateTime CreatedAt{ get; set; }
}
