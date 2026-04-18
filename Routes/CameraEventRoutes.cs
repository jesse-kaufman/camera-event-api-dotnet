using CameraEventApi.Data;
using CameraEventApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CameraEventApi.Routes;

public static class CameraEventRoutes
{
  public static void MapCameraEventRoutes(this WebApplication app)
  {
    var group = app.MapGroup("/api/events");

    //
    // Get camera events
    //
    group.MapGet("/", async (AppDbContext db) => await db.CameraEvents.ToListAsync());

    //
    // Create camera event
    //
    group.MapPost(
      "/",
      async (CameraEvent cameraEvent, AppDbContext db) =>
      {
        db.CameraEvents.Add(cameraEvent);
        await db.SaveChangesAsync();
        return Results.Created($"/api/events/{cameraEvent.Id}", cameraEvent);
      }
    );
  }
}
