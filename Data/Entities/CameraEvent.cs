namespace CameraEventApi.Data.Entities;

public enum DetectionType
{
  Linked,
  Motion,
  Person,
  KnownPerson,
  Vehicle,
  Pet,
}

public class CameraEvent
{
  public int Id { get; set; }
  public DateTime EventTime { get; set; }
  public required string Camera { get; set; }
  public required string Location { get; set; }
  public required DetectionType Type { get; set; }
  public required string ImageFile { get; set; }
  public required string Description { get; set; }
}

public class CreateCameraEventRequest
{
  public required DateTime EventTime { get; set; }
  public required string Camera { get; set; }
  public required string Location { get; set; }
  public required DetectionType Type { get; set; }
  public required string ImageFile { get; set; }
  public required string Description { get; set; }
}
