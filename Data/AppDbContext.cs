using System.Reflection;
using CameraEventApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CameraEventApi.Data;

internal class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<CameraEvent> CameraEvents { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
  }
}
