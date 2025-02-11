using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;

public class DepatureDetail
{
    public int Id { get; set; }

    public Guid TrainId { get; set; }

    public Train? Train { get; set; }

    public int RouteDetailId { get; set; }

    public RouteDetail? RouteDetail { get; set; }

    public TimeSpan DepatureTime { get; set; }

    public bool IsAwayFromTerminal { get; set; }
}

public class DepatureDetailConfigurator : IEntityTypeConfiguration<DepatureDetail>
{
    public void Configure(EntityTypeBuilder<DepatureDetail> builder)
    {
        builder.HasKey(dd => dd.Id);

        builder.Property(dd => dd.TrainId)
            .IsRequired();

        builder.HasOne(dd => dd.Train)
            .WithMany()
            .HasForeignKey(dd => dd.TrainId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(dd => dd.RouteDetailId)
            .IsRequired();

        builder.HasOne(dd => dd.RouteDetail)
            .WithMany(rd => rd.DepatureDetails)
            .HasForeignKey(dd => dd.RouteDetailId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Property(dd => dd.DepatureTime)
            .IsRequired();

        builder.Property(dd => dd.IsAwayFromTerminal)
            .IsRequired();

        builder.HasData(
            new DepatureDetail { Id = 1, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 1, DepatureTime = new TimeSpan(7, 0, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 2, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 2, DepatureTime = new TimeSpan(7, 20, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 3, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 3, DepatureTime = new TimeSpan(7, 30, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 4, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 4, DepatureTime = new TimeSpan(7, 42, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 5, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 5, DepatureTime = new TimeSpan(8, 6, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 6, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 6, DepatureTime = new TimeSpan(8, 18, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 7, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 7, DepatureTime = new TimeSpan(8, 35, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 8, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 8, DepatureTime = new TimeSpan(8, 44, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 9, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 9, DepatureTime = new TimeSpan(8, 50, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 10, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 10, DepatureTime = new TimeSpan(9, 0, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 11, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 11, DepatureTime = new TimeSpan(9, 33, 0), IsAwayFromTerminal = true },

            new DepatureDetail { Id = 12, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 1, DepatureTime = new TimeSpan(12, 39, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 13, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 2, DepatureTime = new TimeSpan(12, 30, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 14, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 3, DepatureTime = new TimeSpan(12, 20, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 15, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 4, DepatureTime = new TimeSpan(12, 0, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 16, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 5, DepatureTime = new TimeSpan(11, 33, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 17, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 6, DepatureTime = new TimeSpan(11, 18, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 18, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 7, DepatureTime = new TimeSpan(11, 3, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 19, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 8, DepatureTime = new TimeSpan(10, 53, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 20, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 9, DepatureTime = new TimeSpan(10, 46, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 21, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 10, DepatureTime = new TimeSpan(10, 36, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 22, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 11, DepatureTime = new TimeSpan(9, 56, 0), IsAwayFromTerminal = false },

            new DepatureDetail { Id = 23, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 1, DepatureTime = new TimeSpan(7+8, 0, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 24, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 2, DepatureTime = new TimeSpan(7+8, 20, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 25, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 3, DepatureTime = new TimeSpan(7+8, 30, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 26, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 4, DepatureTime = new TimeSpan(7+8, 42, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 27, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 5, DepatureTime = new TimeSpan(8+8, 6, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 28, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 6, DepatureTime = new TimeSpan(8+8, 18, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 29, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 7, DepatureTime = new TimeSpan(8+8, 35, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 30, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 8, DepatureTime = new TimeSpan(8+8, 44, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 31, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 9, DepatureTime = new TimeSpan(8+8, 50, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 32, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 10, DepatureTime = new TimeSpan(9+8, 0, 0), IsAwayFromTerminal = true },
            new DepatureDetail { Id = 33, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 11, DepatureTime = new TimeSpan(9+8, 33, 0), IsAwayFromTerminal = true },

            new DepatureDetail { Id = 34, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 1, DepatureTime = new TimeSpan(12+8, 39, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 35, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 2, DepatureTime = new TimeSpan(12+8, 30, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 36, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 3, DepatureTime = new TimeSpan(12+8, 20, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 37, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 4, DepatureTime = new TimeSpan(12+8, 0, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 38, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 5, DepatureTime = new TimeSpan(11+8, 33, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 39, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 6, DepatureTime = new TimeSpan(11+8, 18, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 40, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 7, DepatureTime = new TimeSpan(11+8, 3, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 41, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 8, DepatureTime = new TimeSpan(10+8, 53, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 42, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 9, DepatureTime = new TimeSpan(10+8, 46, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 43, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 10, DepatureTime = new TimeSpan(10+8, 36, 0), IsAwayFromTerminal = false },
            new DepatureDetail { Id = 44, TrainId = Guid.Parse("2d4cd1fb-5e08-457b-9966-d9e8e44bbc93"), RouteDetailId = 11, DepatureTime = new TimeSpan(9+8, 56, 0), IsAwayFromTerminal = false }

            );
    }
}
