using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TrainTicketing.Entities;
public class Departure
{
    public int DepartureId { get; set; }

    public Guid RouteId { get; set; }

    public Route Route { get; set; }

    public ICollection<DepartureDetail> DepartureDetails { get;set; }


}
public class DepatureConfigurator : IEntityTypeConfiguration<Departure>
{
    public void Configure(EntityTypeBuilder<Departure> builder)
    {
        builder.HasOne(d => d.Route)
            .WithMany(r => r.Departures)
            .HasForeignKey(d => d.RouteId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(
            new Departure { DepartureId = 1, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a") },
            new Departure { DepartureId = 2, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a") },
            new Departure { DepartureId = 3, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a") },
            new Departure { DepartureId = 4, RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a") }
            );

    }
}