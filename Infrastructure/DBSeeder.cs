using Infrastructure.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DBSeeder
    {
        private readonly AppDbContext _context;

        public DBSeeder(AppDbContext context)
        {
            _context = context;
        }

        public void SeedDevelopment()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            var cars = new List<CarEntity>
            {
               new CarEntity
                {
                    VIN = "1HGCM82633A123456",
                    Make = "Toyota",
                    Model = "Corolla",
                    Mileage = 30000,
                    Color = "Red",
                    CreatedAt = DateTime.UtcNow
                },
                new CarEntity
                {
                    VIN = "1HGCM82633A654321",
                    Make = "Honda",
                    Model = "Civic",
                    Mileage = 40000,
                    Color = "Blue",
                    CreatedAt = DateTime.UtcNow
                },
                new CarEntity
                {
                    VIN = "1HGCM82633A789012",
                    Make = "Ford",
                    Model = "Fusion",
                    Mileage = 50000,
                    Color = "Green",
                    CreatedAt = DateTime.UtcNow
                }
            };
        }
    }
}
