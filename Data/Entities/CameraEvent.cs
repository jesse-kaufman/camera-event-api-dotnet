namespace CameraEventApi.Data.Entities;

internal enum DetectionType
{
  Linked,
  Motion,
  Person,
  KnownPerson,
  Vehicle,
  Pet,
}

internal class CameraEvent
{
  public int Id { get; set; }
  public DateTime Timestamp { get; set; }
  public required string Camera { get; set; }
  public required string Location { get; set; }
  public required DetectionType Type { get; set; }
  public required string ImageFile { get; set; }
  public required string Description { get; set; }
}

internal class CreateCameraEventRequest
{
  public required DateTime Timestamp { get; set; }
  public required string Camera { get; set; }
  public required string Location { get; set; }
  public required DetectionType Type { get; set; }
  public required string ImageFile { get; set; }
  public required string Description { get; set; }
}
