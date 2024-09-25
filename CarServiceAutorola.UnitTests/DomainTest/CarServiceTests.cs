using Application.Models;
using Domain.IRepositories;
using Domain.Services;
using Moq;

namespace CarServiceAutorola.UnitTests.DomainTest
{
    public class CarServiceTests
    {
        private readonly Mock<ICarRepository> _carRepositoryMock;
        private readonly CarService _carService;
        private readonly CarModel _testCar;
        private readonly List<CarModel> _testCarList;

        public CarServiceTests()
        {
            _carRepositoryMock = new Mock<ICarRepository>();
            _carService = new CarService(_carRepositoryMock.Object);


            //data
            _testCarList = new List<CarModel>
            {
                new CarModel
                {
                    VIN = "1HGCM82633A123456",
                    Make = "Lada",
                    Model = "Niva",
                    Mileage = 400000,
                    Color = "Pink",
                    CreatedAt = DateTime.Now
                },
                new CarModel
                {
                    VIN = "1HGCM82633A654321",
                    Make = "Ford",
                    Model = "Kuga",
                    Mileage = 90000,
                    Color = "Black",
                    CreatedAt = DateTime.Now
                },
            };
        }

        [Fact]
        public async Task AddCar_ReturnAddedCar()
        {
            // Arrange
            var car = _testCarList[0];
            _carRepositoryMock.Setup(repo => repo.AddCar(car)).ReturnsAsync(car);

            // Act
            var result = await _carService.AddCar(car);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(car.VIN, result.VIN);
            _carRepositoryMock.Verify(repo => repo.AddCar(car), Times.Once);
        }

        [Fact]
        public async Task GetAllCars_ReturnListOfCars()
        {
            // Arrange
            _carRepositoryMock.Setup(repo => repo.GetAllCars()).ReturnsAsync(_testCarList);

            // Act
            var result = await _carService.GetAllCars();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
            _carRepositoryMock.Verify(repo => repo.GetAllCars(), Times.Once);
        }

        [Fact]
        public async Task GetCarByVin_ReturnCar()
        {
            var car = _testCarList[0];
            var vin = car.VIN;
            _carRepositoryMock.Setup(repo => repo.GetCarByVinId(vin)).ReturnsAsync(car);

            // Act
            var result = await _carService.GetCarByVin(vin);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(vin, result.VIN);
            _carRepositoryMock.Verify(repo => repo.GetCarByVinId(vin), Times.Once);
        }

        [Fact]
        public async Task UpdateCar_ReturnUpdatedCar()
        {
            // Arrange
            var car = _testCarList[1];
            var updatedCar = new CarModel
            {
                VIN = car.VIN,
                Make = car.Make,
                Model = car.Model,
                Mileage = car.Mileage,
                Color = "Orange",
                CreatedAt = car.CreatedAt
            };
            _carRepositoryMock.Setup(repo => repo.UpdateCar(_testCar)).ReturnsAsync(updatedCar);

            // Act
            var result = await _carService.UpdateCar(_testCar);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(updatedCar.Color, result.Color);

            _carRepositoryMock.Verify(repo => repo.UpdateCar(_testCar), Times.Once);
        }

        [Fact]
        public async Task DeleteCar_ReturnTrue()
        {
            // Arrange
            var vin = _testCarList[0].VIN;
            _carRepositoryMock.Setup(repo => repo.DeleteCar(vin)).ReturnsAsync(true);

            // Act
            var result = await _carService.DeleteCar(vin);

            // Assert
            Assert.True(result);
            _carRepositoryMock.Verify(repo => repo.DeleteCar(vin), Times.Once);
        }
    }
}