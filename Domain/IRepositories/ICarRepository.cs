using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepositories
{
    public interface ICarRepository
    {
        List<CarModel> GetAllCars();
        CarModel GetCarByVinId(string vin);
        CarModel AddCar(CarModel car);
        CarModel UpdateCar(CarModel car);
        CarModel DeleteCar(string vin);
    }
}
