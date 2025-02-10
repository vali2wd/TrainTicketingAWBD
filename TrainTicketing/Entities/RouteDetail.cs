using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class RouteDetail
{
    public int Id { get; }

    public Guid RouteId { get; }

    public Route? Route { get; }

    public Guid StationId { get; }

    public Station? Station { get; }

    public decimal DistanceFromMain {  get; }
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
            .HasPrecision(5,1);
    }
}