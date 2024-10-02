using Application.Models;

namespace Application.IServices
{
    public interface ICarService
    {
        Task<List<CarModel>> GetAllCars();
        Task<CarModel> GetCarByVin(string vin);
        Task<CarModel> AddCar(CarModel car);
        Task<CarModel> UpdateCar(CarModel car);
        Task<bool> DeleteCar(string vin);
    }
}
