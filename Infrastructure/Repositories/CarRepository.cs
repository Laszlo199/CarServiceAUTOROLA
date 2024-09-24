using Application.Models;
using Domain.IRepositories;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Entity;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _ctx;

        public CarRepository(AppDbContext context)
        {
            _ctx = context;
        }

        public async Task<CarModel> AddCar(CarModel car)
        {
            var c = new CarEntity
            {
                VIN = car.VIN,
                Make = car.Make,
                Model = car.Model,
                Mileage = car.Mileage,
                Color = car.Color,
                CreatedAt = car.CreatedAt
            };
            await _ctx.Cars.AddAsync(c);
            await _ctx.SaveChangesAsync();
            return car;
        }

        public async Task<bool> DeleteCar(string vin)
        {
            var car = await _ctx.Cars.FirstOrDefaultAsync(c => c.VIN == vin);
            if (car != null)
            {
                _ctx.Cars.Remove(car);
                await _ctx.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<CarModel>> GetAllCars()
        {
            var cars = await _ctx.Cars
                .Select(c => new CarModel
                {
                    VIN = c.VIN,
                    Make = c.Make,
                    Model = c.Model,
                    Mileage = c.Mileage,
                    Color = c.Color,
                    CreatedAt = c.CreatedAt
                }).ToListAsync();
            return cars;
        }

        public async Task<CarModel> GetCarByVinId(string vin)
        {
            var car = await _ctx.Cars
                .Where(c => c.VIN == vin)
                .Select(c => new CarModel
                  {
                       VIN = c.VIN,
                       Make = c.Make,
                       Model = c.Model,
                       Mileage = c.Mileage,
                       Color = c.Color,
                       CreatedAt = c.CreatedAt
                  }).FirstOrDefaultAsync();

                return car;
        }

        public async Task<CarModel> UpdateCar(CarModel car)
        {
            _ctx.Attach(new CarEntity
            {
                VIN = car.VIN,
                Make = car.Make,
                Model = car.Model,
                Mileage = car.Mileage,
                Color = car.Color,
                CreatedAt = car.CreatedAt
            }).State = EntityState.Modified;
            await _ctx.SaveChangesAsync();

            return car;
        }
    }
}
