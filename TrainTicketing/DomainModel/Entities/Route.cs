using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Entities;

public class Route : Entity
{
    public Guid RouteId { get; set; }

    public string RouteName { get; set; } = null!;

    public Guid MainTerminalId { get; set; }

    public Station MainTerminal { get; set; } = null!;

    public int TariffSchemaId { get; set; }

    public TariffSchema TariffSchema { get; set; } = null!;

    public string ImagePath { get; set; } = null!;

    public ICollection<RouteDetail> RouteDetails { get; set; } = [];

    public ICollection<DepartureSchedule> Departures { get; set; }

    public decimal TotalDistance { get; set; }
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

        builder.Property(r => r.TotalDistance)
            .HasPrecision(8, 4)
            .IsRequired();

        builder.HasData(
            new Route { RouteId = Guid.Parse("3dba6d64-acae-4cee-acff-630ef2b81d2a"), TotalDistance = 169.0m, RouteName = "Bucuresti-Brasov", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" },
            new Route { RouteId = Guid.Parse("6cf15bf2-db1a-4874-b2c7-9be7110eaaf0"), TotalDistance = 169.0m, RouteName = "Ruta6cf15bf2-db1a-4874", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" },
            new Route { RouteId = Guid.Parse("4b13c88b-9c49-4177-91c9-76648b8c8231"), TotalDistance = 169.0m, RouteName = "Ruta4b13c88b-9c49-4177", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" },
            new Route { RouteId = Guid.Parse("e19ada88-c110-4f0f-96ce-ef1ce0bd1738"), TotalDistance = 169.0m, RouteName = "Rutae19ada88-c110-4f0f", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" },
            new Route { RouteId = Guid.Parse("7756bfd1-4020-4193-a342-562d20509df8"), TotalDistance = 169.0m, RouteName = "Ruta7756bfd1-4020-4193", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" },
            new Route { RouteId = Guid.Parse("3757cae8-6223-4c2c-b23c-d514173c449b"), TotalDistance = 169.0m, RouteName = "Ruta3757cae8-6223-4c2c", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" },
            new Route { RouteId = Guid.Parse("1e55a13b-1ce5-4370-bf93-8851415ddedb"), TotalDistance = 169.0m, RouteName = "Ruta1e55a13b-1ce5-4370", MainTerminalId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), TariffSchemaId = 1, ImagePath = "https://trainticketing.blob.core.windows.net/trainticketingimages/ruta_Bucuresti-Brasov.png" }
            );
    }
}