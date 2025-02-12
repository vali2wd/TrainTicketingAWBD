using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;

public class RouteDetail
{
    public int Id { get; set; }

    public Guid RouteId { get; set;}

    public Route? Route { get; set;}

    public Guid StationId { get; set;}

    public Station? Station { get; set;}

    public int OrderOfStationFromMain { get; set; }

    public decimal DistanceFromMain {  get; set;}

    public ICollection<DepartureDetail> DepatureDetails { get; set; } = [];
}

public class RouteDetailConfigurator : IEntityTypeConfiguration<RouteDetail>
{
    public void Configure(EntityTypeBuilder<RouteDetail> builder)
    {
        builder.HasKey(rd => rd.Id);

        builder.Property(rd => rd.RouteId)
            .IsRequired();

        builder.HasOne(rd => rd.Route)
            .WithMany(r => r.RouteDetails)
            .HasForeignKey(rd => rd.RouteId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(rd => rd.StationId)
            .IsRequired();

        builder.HasOne(rd => rd.Station)
            .WithMany()
            .HasForeignKey(rd => rd.StationId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(rd => rd.DistanceFromMain)
            .IsRequired() 
            .HasPrecision(8,4);

        builder.Property(rd => rd.OrderOfStationFromMain)
            .IsRequired();

        builder.HasData(
            new RouteDetail { Id = 1, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), OrderOfStationFromMain = 0, DistanceFromMain = 0m },
            new RouteDetail { Id = 2, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("08b824ab-8ac6-4b24-9872-95ff63b492bf"), OrderOfStationFromMain = 1, DistanceFromMain = 31.3m },
            new RouteDetail { Id = 3, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("0ed5992e-6dda-407a-8481-5233d26c64e0"), OrderOfStationFromMain = 2, DistanceFromMain = 45.0m },
            new RouteDetail { Id = 4, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("6ca13ae5-67f1-413b-b5c2-d89efc164c57"), OrderOfStationFromMain = 3, DistanceFromMain = 61.8m },
            new RouteDetail { Id = 5, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("41ff5b07-7ef4-4daf-b2e2-bb9d653d8245"), OrderOfStationFromMain = 4, DistanceFromMain = 94.3m },
            new RouteDetail { Id = 6, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("0bfcdb5d-163b-4576-b285-f360d6b5bcba"), OrderOfStationFromMain = 5, DistanceFromMain = 109m },
            new RouteDetail { Id = 7, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("62c14434-9039-412e-9e36-dcbd7cbbae4f"), OrderOfStationFromMain = 6, DistanceFromMain = 124m },
            new RouteDetail { Id = 8, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("33024dc9-bf84-4651-94bd-02a774f43c5b"), OrderOfStationFromMain = 7, DistanceFromMain = 130m },
            new RouteDetail { Id = 9, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"),  StationId = Guid.Parse("8daeb4c3-de43-4e5a-8e7e-f4645bb03441"), OrderOfStationFromMain = 8, DistanceFromMain = 137m },
            new RouteDetail { Id = 10, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), StationId = Guid.Parse("a831ce86-f068-4753-ba68-c3f9c9443605"), OrderOfStationFromMain = 9, DistanceFromMain = 143m },
            new RouteDetail { Id = 11, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), StationId = Guid.Parse("66a74a29-282f-4ff9-b5d6-2f49d3d3536f"), OrderOfStationFromMain = 10, DistanceFromMain = 169m }
            );
    }
}