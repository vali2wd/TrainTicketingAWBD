using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TrainTicketing.Entities;
public class Departure
{
    public int DepartureId { get; set; }

    public ICollection<DepartureDetail> DepartureDetails { get;set; }
}
public class DepatureConfigurator : IEntityTypeConfiguration<Departure>
{
    public void Configure(EntityTypeBuilder<Departure> builder)
    {
        builder.HasData(
            new Departure { DepartureId = 1 },
            new Departure { DepartureId = 2 },
            new Departure { DepartureId = 3 },
            new Departure { DepartureId = 4 }
            );

    }
}