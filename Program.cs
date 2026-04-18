using CameraEventApi.Data;
using CameraEventApi.Routes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
  options.UseSqlite(builder.Configuration.GetConnectionString("Db"))
);

var app = builder.Build();

app.UseHttpsRedirection();
app.MapCameraEventRoutes();

app.Run();
