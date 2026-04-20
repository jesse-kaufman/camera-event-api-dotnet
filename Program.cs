using System.Text.Json.Serialization;
using CameraEventApi.Data;
using CameraEventApi.Routes;
using CameraEventApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
  options.UseSqlite(builder.Configuration.GetConnectionString("Db"))
);

builder.Services.AddScoped<CameraEventService>();

builder.Services.ConfigureHttpJsonOptions(options =>
  options.SerializerOptions.Converters.Add(new JsonStringEnumConverter())
);

var app = builder.Build();

app.UseHttpsRedirection();
app.MapCameraEventRoutes();

app.Run();
