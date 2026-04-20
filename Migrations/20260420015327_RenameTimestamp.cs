using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CameraEventApi.Migrations
{
  /// <inheritdoc />
  public partial class RenameTimestamp : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.RenameColumn(name: "Timestamp", table: "CameraEvents", newName: "EventTime");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.RenameColumn(name: "EventTime", table: "CameraEvents", newName: "Timestamp");
    }
  }
}
