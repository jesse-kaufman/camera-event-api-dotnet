using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CameraEventApi.Migrations;

/// <inheritdoc />
public partial class InitDb : Migration
{
  /// <inheritdoc />
  protected override void Up(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.CreateTable(
      name: "CameraEvents",
      columns: table => new
      {
        Id = table.Column<int>(type: "INTEGER", nullable: false).Annotation("Sqlite:Autoincrement", true),
        Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false),
        Camera = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
        Location = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
        Type = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
        ImageFile = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
        Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
      },
      constraints: table => table.PrimaryKey("PK_CameraEvents", x => x.Id)
    );
  }

  /// <inheritdoc />
  protected override void Down(MigrationBuilder migrationBuilder)
  {
    migrationBuilder.DropTable(name: "CameraEvents");
  }
}
