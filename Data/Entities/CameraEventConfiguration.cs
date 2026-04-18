using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraEventApi.Data.Entities;

public class CameraEventConfiguration : IEntityTypeConfiguration<CameraEvent>
{
  public void Configure(EntityTypeBuilder<CameraEvent> builder)
  {
    builder.ToTable("CameraEvents");
    builder.HasKey(e => e.Id);

    builder.Property(e => e.Timestamp).IsRequired();

    builder.Property(e => e.Camera).IsRequired().HasMaxLength(50);

    builder.Property(e => e.Location).IsRequired().HasMaxLength(50);

    builder.Property(e => e.Type).IsRequired().HasConversion<string>().HasMaxLength(20);

    builder.Property(e => e.ImageFile).IsRequired().HasMaxLength(500);

    builder.Property(e => e.Description).IsRequired().HasMaxLength(1000);
  }
}
