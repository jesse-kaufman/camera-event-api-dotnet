using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CameraEventApi.Data.Entities;

internal class CameraEventConfiguration : IEntityTypeConfiguration<CameraEvent>
{
  public void Configure(EntityTypeBuilder<CameraEvent> builder)
  {
    builder.ToTable("CameraEvents");

    // Id
    builder.HasKey(e => e.Id);

    // Timestamp
    builder.Property(e => e.Timestamp).IsRequired();

    // Camera
    builder.Property(e => e.Camera).IsRequired().HasMaxLength(50);

    // Location
    builder.Property(e => e.Location).IsRequired().HasMaxLength(50);

    // Type
    builder.Property(e => e.Type).IsRequired().HasConversion<string>().HasMaxLength(20);

    // ImageFile
    builder.Property(e => e.ImageFile).IsRequired().HasMaxLength(500);

    // Description
    builder.Property(e => e.Description).IsRequired().HasMaxLength(1000);
  }
}
