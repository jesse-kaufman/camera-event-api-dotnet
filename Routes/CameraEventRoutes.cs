using CameraEventApi.Data.Entities;
using CameraEventApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CameraEventApi.Routes;

public static class CameraEventRoutes
{
  public static void MapCameraEventRoutes(this WebApplication app)
  {
    var apiBase = "/api/camera-events";
    var group = app.MapGroup(apiBase);

    //
    // Get camera events
    //
    group.MapGet(
      "/",
      async (
        [FromServices] CameraEventService service,
        string? camera,
        string? location,
        DetectionType? type
      ) => await service.GetAllAsync(camera, location, type)
    );
    //
    // Create camera event
    //
    group.MapPost(
      "/",
      async (CreateCameraEventRequest request, CameraEventService service) =>
      {
        var cameraEvent = await service.SaveAsync(request);
        return Results.Created($"{apiBase}/{cameraEvent.Id}", cameraEvent);
      }
    );
  }
}
