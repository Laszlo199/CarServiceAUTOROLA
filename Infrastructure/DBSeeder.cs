using Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DBSeeder
    {
        private readonly AppDbContext _ctx;

        public DBSeeder(AppDbContext context)
        {
            _ctx = context;
        }

        public void SeedDevelopment()
        {
            var cars = new List<CarEntity>
            {
               new CarEntity
                {
                    VIN = "1HGCM82633A123456",
                    Make = "Toyota",
                    Model = "Corolla",
                    Mileage = 30000,
                    Color = "Red",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    VIN = "1HGCM82633A654321",
                    Make = "Honda",
                    Model = "Civic",
                    Mileage = 40000,
                    Color = "Blue",
                    CreatedAt = DateTime.Now
                },
                new CarEntity
                {
                    VIN = "1HGCM82633A789012",
                    Make = "Ford",
                    Model = "Fusion",
                    Mileage = 40000,
                    Color = "Green",
                    CreatedAt = DateTime.Now
                }
            };
            _ctx.Cars.AddRange(cars);
            _ctx.SaveChanges();
        }
    }
}
