using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Route
{
    public Guid Id { get; set; }

    public string RouteName { get; set; } = null!;

    public Guid MainTerminalId { get; set; }

    public Station MainTerminal { get; set; } = null!;

    public int TariffSchemaId { get; set; }

    public TariffSchema TariffSchema { get; set; } = null!;

    public ICollection<RouteDetail> RouteDetails { get; set; } = [];
}

public class RouteConfigurator : IEntityTypeConfiguration<Route>
{
    public void Configure(EntityTypeBuilder<Route> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.RouteName)
            .IsRequired()
            .HasMaxLength(35);

        builder.HasOne(e => e.TariffSchema)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(r => r.MainTerminal)
            .WithMany()
            .HasForeignKey(r => r.MainTerminalId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}