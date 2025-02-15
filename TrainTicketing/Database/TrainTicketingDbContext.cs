using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TrainTicketing.Entities;
using System.Reflection;
using Microsoft.Identity.Client;

namespace TrainTicketing.Database;
public class TrainTicketingDbContext : IdentityDbContext<IdentityUser>
{
    public TrainTicketingDbContext(DbContextOptions<TrainTicketingDbContext> options) : base(options)
    {

    }

    public DbSet<Announcement> Announcements { get; set; }
   
    public DbSet<Reservation> Reservations { get; set; }
   
    //public DbSet<ReservationsArchive> ReservationsArchive { get; set; }
   
    public DbSet<Route> Routes { get; set; }
   
    public DbSet<RouteDetail> RouteDetails { get; set; }
   
    public DbSet<Seat> Seats { get; set; }
   
    public DbSet<Station> Stations { get; set; }
   
    public DbSet<TariffRanges> TariffRangess { get; set; }
   
    public DbSet<TariffSchema> TariffSchemas { get; set; }
   
    public DbSet<Train> Trains { get; set; }
   
    public DbSet<SeatReservation> SeatReservationDetails { get; set; }

    public DbSet<DepartureDetail> DepartureDetails { get; set; }

    public DbSet<Departure> Departures { get; set; }

    public DbSet<DepartureDates> DepartureDates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<SeatReservation>()
            .HasKey(sr => new { sr.ReservationId, sr.SeatId });

        modelBuilder.Entity<SeatReservation>()
            .HasOne(sr => sr.Seat)
            .WithMany(s => s.SeatReservations)
            .HasForeignKey(sr => sr.SeatId);

        modelBuilder.Entity<SeatReservation>()
            .HasOne(sr => sr.Reservation)
            .WithMany(r => r.SeatReservations)
            .HasForeignKey(sr => sr.ReservationId);
    }
}
