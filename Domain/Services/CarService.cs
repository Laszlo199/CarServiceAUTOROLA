using Application.IServices;
using Application.Models;
using Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
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
            
            return _carRepository.GetAllCars();
        }

        public CarModel GetCarByVin(string vin)
        {
            throw new NotImplementedException();
        }

        public CarModel UpdateCar(CarModel car)
        {
            throw new NotImplementedException();
        }
    }
}
