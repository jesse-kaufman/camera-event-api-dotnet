using CameraEventApi.Data;
using CameraEventApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CameraEventApi.Services;

public class CameraEventService(AppDbContext db)
{
  private readonly AppDbContext _db = db;

  public async Task<List<CameraEvent>> GetAllAsync(
    string? camera = null,
    string? location = null,
    DetectionType? type = null
  )
  {
    var query = _db.CameraEvents.AsQueryable();

    if (camera is not null)
      query = query.Where(ev => ev.Camera == camera);

    if (location is not null)
      query = query.Where(ev => ev.Location == location);

    if (type is not null)
      query = query.Where(ev => ev.Type == type);

    return await _db.CameraEvents.ToListAsync();
  }

  public async Task<CameraEvent> SaveAsync(CreateCameraEventRequest request)
  {
    var cameraEvent = new CameraEvent
    {
      EventTime = request.EventTime,
      Camera = request.Camera,
      Location = request.Location,
      Type = request.Type,
      ImageFile = request.ImageFile,
      Description = request.Description,
    };

    _db.CameraEvents.Add(cameraEvent);
    await _db.SaveChangesAsync();
    return cameraEvent;
  }
}
