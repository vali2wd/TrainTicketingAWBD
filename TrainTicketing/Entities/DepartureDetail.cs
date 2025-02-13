using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;

public class DepartureDetail
{
    public int Id { get; set; }

    public int DepartureId { get; set; }

    public Departure Departure { get; set; }

    public int RouteDetailId { get; set; }

    public RouteDetail? RouteDetail { get; set; }

    public TimeSpan DepatureTime { get; set; }

    public bool OutboundMain { get; set; }
}

public class DepatureDetailConfigurator : IEntityTypeConfiguration<DepartureDetail>
{
    public void Configure(EntityTypeBuilder<DepartureDetail> builder)
    {
        builder.HasKey(dd => dd.Id);


        builder.HasOne(dd => dd.Departure)
            .WithMany(d => d.DepartureDetails)
            .HasForeignKey(dd => dd.DepartureId);

        builder.Property(dd => dd.DepartureId)
            .IsRequired();



        builder.Property(dd => dd.RouteDetailId)
            .IsRequired();

        builder.HasOne(dd => dd.RouteDetail)
            .WithMany(rd => rd.DepatureDetails)
            .HasForeignKey(dd => dd.RouteDetailId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(dd => dd.DepatureTime)
            .IsRequired();

        builder.Property(dd => dd.OutboundMain)
            .IsRequired();

        builder.HasData(
            new DepartureDetail { Id = 1, DepartureId = 1, RouteDetailId = 1, DepatureTime = new TimeSpan(7, 0, 0), OutboundMain = true },
            new DepartureDetail { Id = 2, DepartureId = 1, RouteDetailId = 2, DepatureTime = new TimeSpan(7, 20, 0), OutboundMain = true },
            new DepartureDetail { Id = 3, DepartureId = 1, RouteDetailId = 3, DepatureTime = new TimeSpan(7, 30, 0), OutboundMain = true },
            new DepartureDetail { Id = 4, DepartureId = 1, RouteDetailId = 4, DepatureTime = new TimeSpan(7, 42, 0), OutboundMain = true },
            new DepartureDetail { Id = 5, DepartureId = 1, RouteDetailId = 5, DepatureTime = new TimeSpan(8, 6, 0), OutboundMain = true },
            new DepartureDetail { Id = 6, DepartureId = 1, RouteDetailId = 6, DepatureTime = new TimeSpan(8, 18, 0), OutboundMain = true },
            new DepartureDetail { Id = 7, DepartureId = 1, RouteDetailId = 7, DepatureTime = new TimeSpan(8, 35, 0), OutboundMain = true },
            new DepartureDetail { Id = 8, DepartureId = 1, RouteDetailId = 8, DepatureTime = new TimeSpan(8, 44, 0), OutboundMain = true },
            new DepartureDetail { Id = 9, DepartureId = 1, RouteDetailId = 9, DepatureTime = new TimeSpan(8, 50, 0), OutboundMain = true },
            new DepartureDetail { Id = 10, DepartureId = 1, RouteDetailId = 10, DepatureTime = new TimeSpan(9, 0, 0), OutboundMain = true },
            new DepartureDetail { Id = 11, DepartureId = 1, RouteDetailId = 11, DepatureTime = new TimeSpan(9, 33, 0), OutboundMain = true },

            new DepartureDetail { Id = 12, DepartureId = 2, RouteDetailId = 1, DepatureTime = new TimeSpan(12, 39, 0), OutboundMain = false },
            new DepartureDetail { Id = 13, DepartureId = 2, RouteDetailId = 2, DepatureTime = new TimeSpan(12, 30, 0), OutboundMain = false },
            new DepartureDetail { Id = 14, DepartureId = 2, RouteDetailId = 3, DepatureTime = new TimeSpan(12, 20, 0), OutboundMain = false },
            new DepartureDetail { Id = 15, DepartureId = 2, RouteDetailId = 4, DepatureTime = new TimeSpan(12, 0, 0), OutboundMain = false },
            new DepartureDetail { Id = 16, DepartureId = 2, RouteDetailId = 5, DepatureTime = new TimeSpan(11, 33, 0), OutboundMain = false },
            new DepartureDetail { Id = 17, DepartureId = 2, RouteDetailId = 6, DepatureTime = new TimeSpan(11, 18, 0), OutboundMain = false },
            new DepartureDetail { Id = 18, DepartureId = 2, RouteDetailId = 7, DepatureTime = new TimeSpan(11, 3, 0), OutboundMain = false },
            new DepartureDetail { Id = 19, DepartureId = 2, RouteDetailId = 8, DepatureTime = new TimeSpan(10, 53, 0), OutboundMain = false },
            new DepartureDetail { Id = 20, DepartureId = 2, RouteDetailId = 9, DepatureTime = new TimeSpan(10, 46, 0), OutboundMain = false },
            new DepartureDetail { Id = 21, DepartureId = 2, RouteDetailId = 10, DepatureTime = new TimeSpan(10, 36, 0), OutboundMain = false },
            new DepartureDetail { Id = 22, DepartureId = 2, RouteDetailId = 11, DepatureTime = new TimeSpan(9, 56, 0), OutboundMain = false },

            new DepartureDetail { Id = 23, DepartureId = 3, RouteDetailId = 1, DepatureTime = new TimeSpan(7 + 8, 0, 0), OutboundMain = true },
            new DepartureDetail { Id = 24, DepartureId = 3, RouteDetailId = 2, DepatureTime = new TimeSpan(7 + 8, 20, 0), OutboundMain = true },
            new DepartureDetail { Id = 25, DepartureId = 3, RouteDetailId = 3, DepatureTime = new TimeSpan(7 + 8, 30, 0), OutboundMain = true },
            new DepartureDetail { Id = 26, DepartureId = 3, RouteDetailId = 4, DepatureTime = new TimeSpan(7 + 8, 42, 0), OutboundMain = true },
            new DepartureDetail { Id = 27, DepartureId = 3, RouteDetailId = 5, DepatureTime = new TimeSpan(8 + 8, 6, 0), OutboundMain = true },
            new DepartureDetail { Id = 28, DepartureId = 3, RouteDetailId = 6, DepatureTime = new TimeSpan(8 + 8, 18, 0), OutboundMain = true },
            new DepartureDetail { Id = 29, DepartureId = 3, RouteDetailId = 7, DepatureTime = new TimeSpan(8 + 8, 35, 0), OutboundMain = true },
            new DepartureDetail { Id = 30, DepartureId = 3, RouteDetailId = 8, DepatureTime = new TimeSpan(8 + 8, 44, 0), OutboundMain = true },
            new DepartureDetail { Id = 31, DepartureId = 3, RouteDetailId = 9, DepatureTime = new TimeSpan(8 + 8, 50, 0), OutboundMain = true },
            new DepartureDetail { Id = 32, DepartureId = 3, RouteDetailId = 10, DepatureTime = new TimeSpan(9 + 8, 0, 0), OutboundMain = true },
            new DepartureDetail { Id = 33, DepartureId = 3, RouteDetailId = 11, DepatureTime = new TimeSpan(9 + 8, 33, 0), OutboundMain = true },

            new DepartureDetail { Id = 34, DepartureId = 4, RouteDetailId = 1, DepatureTime = new TimeSpan(12 + 8, 39, 0), OutboundMain = false },
            new DepartureDetail { Id = 35, DepartureId = 4, RouteDetailId = 2, DepatureTime = new TimeSpan(12 + 8, 30, 0), OutboundMain = false },
            new DepartureDetail { Id = 36, DepartureId = 4, RouteDetailId = 3, DepatureTime = new TimeSpan(12 + 8, 20, 0), OutboundMain = false },
            new DepartureDetail { Id = 37, DepartureId = 4, RouteDetailId = 4, DepatureTime = new TimeSpan(12 + 8, 0, 0), OutboundMain = false },
            new DepartureDetail { Id = 38, DepartureId = 4, RouteDetailId = 5, DepatureTime = new TimeSpan(11 + 8, 33, 0), OutboundMain = false },
            new DepartureDetail { Id = 39, DepartureId = 4, RouteDetailId = 6, DepatureTime = new TimeSpan(11 + 8, 18, 0), OutboundMain = false },
            new DepartureDetail { Id = 40, DepartureId = 4, RouteDetailId = 7, DepatureTime = new TimeSpan(11 + 8, 3, 0), OutboundMain = false },
            new DepartureDetail { Id = 41, DepartureId = 4, RouteDetailId = 8, DepatureTime = new TimeSpan(10 + 8, 53, 0), OutboundMain = false },
            new DepartureDetail { Id = 42, DepartureId = 4, RouteDetailId = 9, DepatureTime = new TimeSpan(10 + 8, 46, 0), OutboundMain = false },
            new DepartureDetail { Id = 43, DepartureId = 4, RouteDetailId = 10, DepatureTime = new TimeSpan(10 + 8, 36, 0), OutboundMain = false },
            new DepartureDetail { Id = 44, DepartureId = 4, RouteDetailId = 11, DepatureTime = new TimeSpan(9 + 8, 56, 0), OutboundMain = false }

            );
    }
}
