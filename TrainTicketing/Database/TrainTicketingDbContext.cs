using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TrainTicketing.DomainModel.Entities;
using TrainTicketing.DomainModel.Aggregates.DailyDeparture;
using Infrastructure.Helpers;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace TrainTicketing.Database;
public class TrainTicketingDbContext : IdentityDbContext<IdentityUser>
{
    public TrainTicketingDbContext(DbContextOptions<TrainTicketingDbContext> options) : base(options)
    {

    }

    public DbSet<Announcement> Announcements { get; set; }

    //public DbSet<Reservation> Reservations { get; set; }

    //public DbSet<ReservationsArchive> ReservationsArchive { get; set; }

    public DbSet<Route> Routes { get; set; }
   
    public DbSet<RouteDetail> RouteDetails { get; set; }
   
    public DbSet<Seat> Seats { get; set; }
   
    public DbSet<Station> Stations { get; set; }
   
    public DbSet<TariffRanges> TariffRangess { get; set; }
   
    public DbSet<TariffSchema> TariffSchemas { get; set; }
   
    public DbSet<Train> Trains { get; set; }
   
    public DbSet<DepartureDetail> DepartureDetails { get; set; }

    public DbSet<DepartureSchedule> DepartureSchedules { get; set; }

    public DbSet<DailyDeparture> DailyDepartures { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        //SeedUsersRoles seedUsersRoles = new();
        //modelBuilder.Entity<IdentityRole>().HasData(seedUsersRoles.Roles);
        //modelBuilder.Entity<IdentityUser>().HasData(seedUsersRoles.Users);
        //modelBuilder.Entity<IdentityUserRole<string>>().HasData(seedUsersRoles.UserRoles);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings =>
                    warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}
