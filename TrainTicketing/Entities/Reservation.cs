using Microsoft.AspNetCore.Identity;

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
