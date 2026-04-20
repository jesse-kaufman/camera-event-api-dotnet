using System.Reflection;
using CameraEventApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CameraEventApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public required DbSet<CameraEvent> CameraEvents { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}
