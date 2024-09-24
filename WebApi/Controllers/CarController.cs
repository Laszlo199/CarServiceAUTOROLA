using Application.IServices;
using Application.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var carClaim = await _carService.GetAllCars();
            return Ok(carClaim);
        }

        [HttpGet("{vin}")]
        public async Task<IActionResult> GetCarByVin(string vin)
        {
            var carClaim = await _carService.GetCarByVin(vin);
            if (carClaim is null)
            {
                return NotFound();
            }
            return Ok(carClaim);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNewCar([Required] [FromBody] CarModel car)
        {
            var wasCreated = await _carService.AddCar(car);
            if (wasCreated is null)
            {
                return BadRequest();
            }
            return Ok(wasCreated);
        }

        [HttpDelete("{vin}")]
        public async Task<IActionResult> DeleteCar(string vin)
        {
            var wasDeleted = await _carService.DeleteCar(vin);
            if (wasDeleted is false)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar([Required] [FromBody] CarModel car)
        {
            var wasUpdated = await _carService.UpdateCar(car);
            if (wasUpdated is null)
            {
                return BadRequest();
            }
            return Ok(wasUpdated);
        }
    }
}
