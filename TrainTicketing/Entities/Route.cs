using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Route
{
    public Guid RouteId { get; set; }

    public string RouteName { get; set; } = null!;

    public Guid MainTerminalId { get; set; }

    public Station MainTerminal { get; set; } = null!;

    public int TariffSchemaId { get; set; }

    public TariffSchema TariffSchema { get; set; } = null!;
    
    public string ImagePath { get; set; } = null!;

    public ICollection<RouteDetail> RouteDetails { get; set; } = [];
}

public class RouteConfigurator : IEntityTypeConfiguration<Route>
{
    public void Configure(EntityTypeBuilder<Route> builder)
    {
        builder.HasKey(r => r.RouteId);

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

        builder.HasData(
            new Route { RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), RouteName = "Bucuresti-Brasov", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" }
            );
    }
}