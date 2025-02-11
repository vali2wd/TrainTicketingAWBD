using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class TariffRanges
{
    public int TariffRangeId { get; set; }

    public decimal StartKm { get; set; }

    //when empty, will compute as price per 100 of kilometers
    public decimal? EndKm { get; set; }

    //TODO : change to TripPrice instead of price per km
    public decimal PricePerKm { get; set; }

    public int TariffSchemaId { get; set; }

    public TariffSchema TariffSchema { get; set; }

    public SeatClass SeatClass { get; set; }
}

public class TariffRangesConfigurator : IEntityTypeConfiguration<TariffRanges>
{
    public void Configure(EntityTypeBuilder<TariffRanges> builder)
    {
        builder.HasKey(t => t.TariffRangeId);
        builder.Property(t => t.StartKm)
            .IsRequired()
            .HasPrecision(8, 4);
        builder.Property(t => t.EndKm)
            .HasPrecision(8, 4);
        builder.Property(t => t.PricePerKm)
            .IsRequired()
            .HasPrecision(8, 4);
        builder.Property(t => t.SeatClass)
            .IsRequired();
        //convert the seatclass to enum Seat Class
        builder.Property(t => t.SeatClass)
            .HasConversion<int>();

        builder.HasOne(e => e.TariffSchema)
            .WithMany(e => e.TariffRanges)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasData(
            new TariffRanges { TariffRangeId = 1, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 1, EndKm = 1 + 9, PricePerKm = 6.0m },
            new TariffRanges { TariffRangeId = 2, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 11, EndKm = 11 + 9, PricePerKm = 7.5m },
            new TariffRanges { TariffRangeId = 3, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 21, EndKm = 21 + 9, PricePerKm = 10.5m },
            new TariffRanges { TariffRangeId = 4, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 31, EndKm = 31 + 9, PricePerKm = 12.5m },
            new TariffRanges { TariffRangeId = 5, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 41, EndKm = 41 + 9, PricePerKm = 16.5m },
            new TariffRanges { TariffRangeId = 6, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 51, EndKm = 51 + 9, PricePerKm = 17.5m },
            new TariffRanges { TariffRangeId = 7, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 61, EndKm = 61 + 9, PricePerKm = 20.5m },
            new TariffRanges { TariffRangeId = 8, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 71, EndKm = 71 + 9, PricePerKm = 23.0m },
            new TariffRanges { TariffRangeId = 9, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 81, EndKm = 81 + 9, PricePerKm = 26.0m },
            new TariffRanges { TariffRangeId = 10, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 91, EndKm = 91 + 9, PricePerKm = 28.0m },
            new TariffRanges { TariffRangeId = 11, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 101, EndKm = 101 + 19, PricePerKm = 34.0m },
            new TariffRanges { TariffRangeId = 12, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 121, EndKm = 121 + 19, PricePerKm = 39.5m },
            new TariffRanges { TariffRangeId = 13, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 141, EndKm = 141 + 19, PricePerKm = 44.5m },
            new TariffRanges { TariffRangeId = 14, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 161, EndKm = 161 + 19, PricePerKm = 51.5m },
            new TariffRanges { TariffRangeId = 15, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 181, EndKm = 181 + 19, PricePerKm = 57.0m },
            new TariffRanges { TariffRangeId = 16, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 201, EndKm = 201 + 49, PricePerKm = 65.0m },
            new TariffRanges { TariffRangeId = 17, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 251, EndKm = 251 + 49, PricePerKm = 75.5m },
            new TariffRanges { TariffRangeId = 18, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 301, EndKm = 301 + 49, PricePerKm = 86.5m },
            new TariffRanges { TariffRangeId = 19, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 351, EndKm = 351 + 49, PricePerKm = 100.0m },
            new TariffRanges { TariffRangeId = 20, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 401, EndKm = 500, PricePerKm = 121.0m },
            new TariffRanges { TariffRangeId = 21, TariffSchemaId = 1, SeatClass = SeatClass.First, StartKm = 501, EndKm = null, PricePerKm = 26.0m },
            new TariffRanges { TariffRangeId = 22, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 1, EndKm = 1 + 9, PricePerKm = 4.0m },
            new TariffRanges { TariffRangeId = 23, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 11, EndKm = 11 + 9, PricePerKm = 5.0m },
            new TariffRanges { TariffRangeId = 24, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 21, EndKm = 21 + 9, PricePerKm = 7.0m },
            new TariffRanges { TariffRangeId = 25, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 31, EndKm = 31 + 9, PricePerKm = 8.5m },
            new TariffRanges { TariffRangeId = 26, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 41, EndKm = 41 + 9, PricePerKm = 11.0m },
            new TariffRanges { TariffRangeId = 27, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 51, EndKm = 51 + 9, PricePerKm = 12.0m },
            new TariffRanges { TariffRangeId = 28, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 61, EndKm = 61 + 9, PricePerKm = 14.0m },
            new TariffRanges { TariffRangeId = 29, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 71, EndKm = 71 + 9, PricePerKm = 15.5m },
            new TariffRanges { TariffRangeId = 30, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 81, EndKm = 81 + 9, PricePerKm = 17.5m },
            new TariffRanges { TariffRangeId = 31, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 91, EndKm = 91 + 9, PricePerKm = 19.0m },
            new TariffRanges { TariffRangeId = 32, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 101, EndKm = 101 + 19, PricePerKm = 23.0m },
            new TariffRanges { TariffRangeId = 33, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 121, EndKm = 121 + 19, PricePerKm = 26.5m },
            new TariffRanges { TariffRangeId = 34, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 141, EndKm = 141 + 19, PricePerKm = 30.0m },
            new TariffRanges { TariffRangeId = 35, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 161, EndKm = 161 + 19, PricePerKm = 34.5m },
            new TariffRanges { TariffRangeId = 36, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 181, EndKm = 181 + 19, PricePerKm = 38.0m },
            new TariffRanges { TariffRangeId = 37, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 201, EndKm = 201 + 49, PricePerKm = 43.5m },
            new TariffRanges { TariffRangeId = 38, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 251, EndKm = 251 + 49, PricePerKm = 50.5m },
            new TariffRanges { TariffRangeId = 39, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 301, EndKm = 301 + 49, PricePerKm = 58.0m },
            new TariffRanges { TariffRangeId = 40, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 351, EndKm = 351 + 49, PricePerKm = 67.0m },
            new TariffRanges { TariffRangeId = 41, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 401, EndKm = 500, PricePerKm = 81.0m },
            new TariffRanges { TariffRangeId = 42, TariffSchemaId = 1, SeatClass = SeatClass.Second, StartKm = 501, EndKm = null, PricePerKm = 17.5m }
            );
    }
}