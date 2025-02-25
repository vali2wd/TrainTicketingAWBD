using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TrainTicketing.Database;
using TrainTicketing.DomainModel.Aggregates.DailyDeparture;
using TrainTicketing.DomainModel.Entities;

namespace WMS.Tests.Fakes;

public class TrainTicketingContextFake : TrainTicketingDbContext
{
    public TrainTicketingContextFake()
        : base(new DbContextOptionsBuilder<TrainTicketingDbContext>()
                    .UseInMemoryDatabase(databaseName: $"TrainTicketingContextFake-{Guid.NewGuid()}")
                    .Options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //modelBuilder.Entity<Station>().HasData(
        //    new Station { StationId = new Guid("9c14181f-75f1-400e-9b84-36ca879bd944"), StationName = "Station 1" },
        //    new Station { StationId = new Guid("b0e66fed-7fe8-4f16-8f49-3bfcea8ff908"), StationName = "Station 2" },
        //    new Station { StationId = new Guid("9a671c9b-43e6-416d-bd1f-c2f1140700f0"), StationName = "Station 3" }
        //    );
        //modelBuilder.Entity<Train>().HasData(
        //    new Train { TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), TrainName = "Express A", TrainType = TrainType.IR });

        //     modelBuilder.Entity<Seat>().HasData(
        //new Seat { SeatId = 1, SeatCode = "1", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 2, SeatCode = "2", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 3, SeatCode = "3", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 4, SeatCode = "4", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 5, SeatCode = "5", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 6, SeatCode = "6", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 7, SeatCode = "7", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 8, SeatCode = "8", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First },
        //new Seat { SeatId = 9, SeatCode = "9", TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), SeatClass = SeatClass.First }
        //);

        //modelBuilder.Entity<TariffSchema>().HasData(
        //    new TariffSchema { TariffSchemaId = 1, TariffSchemaName = "Standard" });


        //modelBuilder.Entity<Route>().HasData(
        //     new Route { RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), TotalDistance = 169.0m, RouteName = "Bucuresti-Brasov", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" }
        //    );

        ////Route 1: A → B → C
        //modelBuilder.Entity<RouteDetail>().HasData(
        //    new RouteDetail { Id = 1, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), StationId = Guid.Parse("9c14181f-75f1-400e-9b84-36ca879bd944"), OrderOfStationFromMain = 0, DistanceFromMain = 0m },
        //    new RouteDetail { Id = 2, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), StationId = Guid.Parse("b0e66fed-7fe8-4f16-8f49-3bfcea8ff908"), OrderOfStationFromMain = 1, DistanceFromMain = 31.3m },
        //    new RouteDetail { Id = 3, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), StationId = Guid.Parse("9a671c9b-43e6-416d-bd1f-c2f1140700f0"), OrderOfStationFromMain = 2, DistanceFromMain = 45.0m });

        //modelBuilder.Entity<DepartureSchedule>().HasData(
        //   new DepartureSchedule { DepartureScheduleId = 1, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), OutboundMain = true });

        //modelBuilder.Entity<DepartureDetail>().HasData(
        //    new DepartureDetail { Id = 1, DepartureId = 1, RouteDetailId = 1, DepatureTime = new TimeSpan(7, 0, 0) },
        //    new DepartureDetail { Id = 2, DepartureId = 1, RouteDetailId = 2, DepatureTime = new TimeSpan(7, 20, 0) },
        //    new DepartureDetail { Id = 3, DepartureId = 1, RouteDetailId = 3, DepatureTime = new TimeSpan(7, 30, 0) });

        //// One Daily Departure happening 2025 - Dec. - 1st
        ////      One Reservation Seat 2 A to B
        ////      One Reservation Seat 1 A to C
        //modelBuilder.Entity<DailyDeparture>().HasData(
        //   new DailyDeparture { DailyDepartureId = 1, DateOfDeparture = new DateTime(2025, 12, 1), DepartureScheduleId = 1 });
        
    }
}

