using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TrainTicketing.DomainModel.Kernel;

namespace TrainTicketing.DomainModel.Entities;
public class Station : Entity
{
    public Guid StationId { get; set; }

    public string StationName { get; set; } = null!;
}

public class StationConfigurator : IEntityTypeConfiguration<Station>
{
    public void Configure(EntityTypeBuilder<Station> builder)
    {
        builder.HasKey(s => s.StationId);
        builder.Property(s => s.StationName)
            .IsRequired()
            .HasMaxLength(35);

        builder.HasData(
            new Station { StationId = Guid.Parse("8f1fd997-1261-450b-912f-8c90650e49d5"), StationName = "Bucuresti" },
            new Station { StationId = Guid.Parse("08b824ab-8ac6-4b24-9872-95ff63b492bf"), StationName = "Peris" },
            new Station { StationId = Guid.Parse("0ed5992e-6dda-407a-8481-5233d26c64e0"), StationName = "Crivina" },
            new Station { StationId = Guid.Parse("6ca13ae5-67f1-413b-b5c2-d89efc164c57"), StationName = "Ploiesti Vest" },
            new Station { StationId = Guid.Parse("41ff5b07-7ef4-4daf-b2e2-bb9d653d8245"), StationName = "Campina" },
            new Station { StationId = Guid.Parse("0bfcdb5d-163b-4576-b285-f360d6b5bcba"), StationName = "Comarnic" },
            new Station { StationId = Guid.Parse("62c14434-9039-412e-9e36-dcbd7cbbae4f"), StationName = "Sinaia" },
            new Station { StationId = Guid.Parse("33024dc9-bf84-4651-94bd-02a774f43c5b"), StationName = "Busteni" },
            new Station { StationId = Guid.Parse("8daeb4c3-de43-4e5a-8e7e-f4645bb03441"), StationName = "Azuga" },
            new Station { StationId = Guid.Parse("a831ce86-f068-4753-ba68-c3f9c9443605"), StationName = "Predeal" },
            new Station { StationId = Guid.Parse("66a74a29-282f-4ff9-b5d6-2f49d3d3536f"), StationName = "Brasov" },
            new Station { StationId = Guid.Parse("4d739b70-baaf-4367-9a1a-9d91481e2762"), StationName = "Pasarea" },
            new Station { StationId = Guid.Parse("4dd2478d-9065-495c-8696-bd96a842d4a2"), StationName = "Fundulea" },
            new Station { StationId = Guid.Parse("717df56e-fe44-4544-b22e-95398bfb653a"), StationName = "Lehliu Gara" },
            new Station { StationId = Guid.Parse("49270139-4185-42e0-9dd9-19e632a4105c"), StationName = "Ciulnita" },
            new Station { StationId = Guid.Parse("760cf2a1-f42b-4169-8022-497a9826eea4"), StationName = "Fetesti" },
            new Station { StationId = Guid.Parse("dbf75826-aa0d-4431-a0b4-ff1228a0a886"), StationName = "Buzau" },
            new Station { StationId = Guid.Parse("2086698a-e330-439b-ab3d-4dea78c7e688"), StationName = "Faurei" },
            new Station { StationId = Guid.Parse("89825248-a590-4dbb-913a-fc37567c2765"), StationName = "Tandarei" },
            new Station { StationId = Guid.Parse("bd245552-935b-40a6-bf09-bdba25d09443"), StationName = "Fetesti" },
            new Station { StationId = Guid.Parse("4806be82-6db7-421c-89b5-d92861bb3fbc"), StationName = "Medgidia" },
            new Station { StationId = Guid.Parse("2d1f9718-ce63-4fc9-be0f-fa1d236d5b19"), StationName = "Constanta" },
            new Station { StationId = Guid.Parse("03905450-41ef-4639-9713-ba663c3773da"), StationName = "Eforie Nord" },
            new Station { StationId = Guid.Parse("45ac2f22-2dae-4d32-ad38-34be33fe6a83"), StationName = "Eforie Sud" },
            new Station { StationId = Guid.Parse("644540c4-421a-4c79-b1e8-a4c7c8767ac3"), StationName = "Costinesti Tabara" },
            new Station { StationId = Guid.Parse("24bb1e5a-4c25-442d-82d3-8ea74348da0f"), StationName = "Neptun" },
            new Station { StationId = Guid.Parse("18d9c104-e905-4de8-a4d7-eead496ac5a2"), StationName = "Mangalia" },
            new Station { StationId = Guid.Parse("d5d4784b-d3db-474f-aa8a-0508a27753b5"), StationName = "Parc Mogosoaia" },
            new Station { StationId = Guid.Parse("a419a47a-335d-4166-a744-3396142333ce"), StationName = "Patinoar" },
            new Station { StationId = Guid.Parse("542784d4-2297-4a15-b198-81d5f918c12e"), StationName = "Otopeni" },
            new Station { StationId = Guid.Parse("c93ed874-9c18-4869-8958-dce572502796"), StationName = "Gradinari" },
            new Station { StationId = Guid.Parse("55296397-fc75-4d01-ba49-d3c497596d37"), StationName = "Vadu Lat" },
            new Station { StationId = Guid.Parse("12279946-5418-4d15-baf9-4daee8566525"), StationName = "Videle" },
            new Station { StationId = Guid.Parse("ac266cf0-3f2c-4aef-baab-2de4d17b2a19"), StationName = "Galateni" },
            new Station { StationId = Guid.Parse("f2a36100-4f48-467d-a72b-36f47e0b90de"), StationName = "Radoiesti" },
            new Station { StationId = Guid.Parse("3ef9ccc2-4501-4d00-a5cd-b4f9b94b645d"), StationName = "Rosiorii de Vede" }
            );
    }


}
