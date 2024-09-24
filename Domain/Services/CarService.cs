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
        public async Task<CarModel> AddCar(CarModel car)
        {
            return await _carRepository.AddCar(car);
        }

        public async Task<bool> DeleteCar(string vin)
        {
            return await _carRepository.DeleteCar(vin);
        }

        public async Task<List<CarModel>> GetAllCars()
        {
            
            return await _carRepository.GetAllCars();
        }

        public async Task<CarModel> GetCarByVin(string vin)
        {
            return await _carRepository.GetCarByVinId(vin);
        }

        public async Task<CarModel> UpdateCar(CarModel car)
        {
            return await _carRepository.UpdateCar(car);
        }
    }
}
