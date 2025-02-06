using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainTicketing.Entities;
using System.Reflection.Emit;
using System.Reflection;

namespace TrainTicketing.Database;
public class DbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<ReservationsArchive> ReservationsArchive { get; set; }
    public DbSet<Route> Routes { get; set; }
    public DbSet<RouteDetail> RouteDetails { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<Station> Stations { get; set; }
    public DbSet<TariffRanges> TariffRangess { get; set; }
    public DbSet<TariffSchema> TariffSchemas { get; set; }
    public DbSet<Train> Trains { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
