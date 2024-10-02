using Application.IServices;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WebApi.Dtos;
using WebApi.Mappers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;
        private readonly CarsMapper _carsMapper;

        public CarController(ICarService carService, CarsMapper carsMapper)
        {
            _carService = carService;
            _carsMapper = carsMapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var carClaim = await _carService.GetAllCars();
            if (carClaim == null || !carClaim.Any())
            {
                return NotFound("No cars found.");
            }
            return Ok(carClaim);
        }

        [HttpGet("{vin}")]
        public async Task<IActionResult> GetCarByVin(string vin)
        {
            var carClaim = await _carService.GetCarByVin(vin);
            if (carClaim is null)
            {
                return NotFound($"Car with VIN '{vin}' not found.");
            }
            return Ok(carClaim);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewCar([Required] [FromBody] CarDto car)
        {
            var carModel = _carsMapper.MapToCarModel(car);
            var wasCreated = await _carService.AddCar(carModel);
            if (wasCreated is null)
            {
                return BadRequest("Failed to create the car. Please check the input data.");
            }
            return Ok(wasCreated);
        }

        [HttpDelete("{vin}")]
        public async Task<IActionResult> DeleteCar(string vin)
        {
            var wasDeleted = await _carService.DeleteCar(vin);
            if (!wasDeleted)
            {
                return NotFound($"Car with VIN '{vin}' not found or could not be deleted.");
            }
            return Ok($"Car has been deleted with VIN '{vin}'.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar([Required] [FromBody] CarDto car)
        {
            var carModel = _carsMapper.MapToCarModel(car);
            var wasUpdated = await _carService.UpdateCar(carModel);
            if (wasUpdated is null)
            {
                return BadRequest($"Car with VIN '{car.VIN}' not found or could not be updated.");
            }
            return Ok(wasUpdated);
        }
    }
}
