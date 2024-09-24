using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.IServices
{
    public interface ICarService
    {
        List<CarModel> GetAllCars();
        CarModel GetCarByVin(string vin);
        CarModel AddCar(CarModel car);
        CarModel UpdateCar(CarModel car);
        CarModel DeleteCar(string vin);
    }
}
