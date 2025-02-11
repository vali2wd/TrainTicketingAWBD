using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TrainTicketing.Entities;

public class DepatureDetail
{
    public int Id { get; set; }
 
    public Guid TrainId { get; set; }
    
    public Train? Train { get; set; }
    
    public int RouteDetailId{ get; set; }
    
    public RouteDetail? RouteDetail { get; set; }
    
    public DateTime DepatureTime { get; set; }

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
    }
}
