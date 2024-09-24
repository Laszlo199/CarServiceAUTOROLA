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
                    CreatedAt = 2001
                },
                new CarEntity
                {
                    VIN = "1HGCM82633A654321",
                    Make = "Honda",
                    Model = "Civic",
                    Mileage = 40000,
                    Color = "Blue",
                    CreatedAt = 1991
                },
                new CarEntity
                {
                    VIN = "1HGCM82633A789012",
                    Make = "Ford",
                    Model = "Fusion",
                    Mileage = 40000,
                    Color = "Green",
                    CreatedAt = 2011
                }
            };
            _ctx.Cars.AddRange(cars);
            _ctx.SaveChanges();
        }
    }
}
