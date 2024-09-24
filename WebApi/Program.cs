using Application.IServices;
using Domain.Services;
using Domain.IRepositories;
using Infrastructure.Repositories;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICarService, CarService>();
builder.Services.AddScoped<ICarRepository, CarRepository>();
builder.Services.AddScoped<DBSeeder>();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("CarDatabase"));

var app = builder.Build();

// Seed the database
void SeedDatabase(WebApplication app)
{
    using var scope = app.Services.CreateScope();
    var dbSeeder = scope.ServiceProvider.GetRequiredService<DBSeeder>();
    dbSeeder.SeedDevelopment();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    SeedDatabase(app);
}

app.MapControllers();
app.Run();
