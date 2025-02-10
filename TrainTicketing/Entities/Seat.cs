using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;
public class Seat
{
    public int SeatId { get; }

    public string SeatCode { get; } = null!;

    public SeatClass SeatClass{ get; set; }

    public List<SeatReservation> SeatReservations { get; } = [];

}

public class SeatConfigurator : IEntityTypeConfiguration<Seat>
{
    public void Configure(EntityTypeBuilder<Seat> builder)
    {
        builder.HasKey(s => s.SeatId);
        builder.Property(s => s.SeatCode)
            .IsRequired()
            .HasMaxLength(3);
        builder.Property(s => s.SeatClass)
            .IsRequired();

    }
}