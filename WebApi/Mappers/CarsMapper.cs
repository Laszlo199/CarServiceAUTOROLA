using Application.Models;
using WebApi.Dtos;

namespace WebApi.Mappers
{
    public class CarsMapper
    {
        public CarModel MapToCarModel(CarDto carDto)
        {
            return new CarModel
            {
                VIN = carDto.VIN,
                Make = carDto.Make,
                Model = carDto.Model,
                Mileage = carDto.Mileage,
                Color = carDto.Color,
                CreatedAt = carDto.CreatedAt
            };
        }
    }
}
