using Application.Models;

namespace Domain.IRepositories
{
    public interface ICarRepository
    {
        Task<List<CarModel>> GetAllCars();
        Task<CarModel> GetCarByVinId(string vin);
        Task<CarModel> AddCar(CarModel car);
        Task<CarModel> UpdateCar(CarModel car);
        Task<bool> DeleteCar(string vin);
    }
}
