using Application.Models;
using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _ctx;

        public CarRepository(AppDbContext context)
        {
            _ctx = context;
        }

        public CarModel AddCar(CarModel car)
        {
            throw new NotImplementedException();
        }

        public CarModel DeleteCar(string vin)
        {
            throw new NotImplementedException();
        }

        public List<CarModel> GetAllCars()
        {
            var cars = _ctx.Cars
                .Select(c => new CarModel
                {
                    VIN = c.VIN,
                    Make = c.Make,
                    Model = c.Model,
                    Mileage = c.Mileage,
                    Color = c.Color,
                    CreatedAt = c.CreatedAt
                }).ToList();
            return cars;
        }

        public CarModel GetCarByVinId(string vin)
        {
            throw new NotImplementedException();
        }

        public CarModel UpdateCar(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
