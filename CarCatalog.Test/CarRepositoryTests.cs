using CarCatalog.DAL.Models;
using CarCatalog.DAL.Parameters;
using CarCatalog.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CarCatalog.Test
{
    public class CarRepositoryTests
    {
        private DbContextOptions<CarCatalogContext> opt = new DbContextOptionsBuilder<CarCatalogContext>()
                .UseInMemoryDatabase("CarCatalog")
                .Options;

        public CarRepositoryTests()
        {
            Seeder.SeedTestData(opt);
        }

        [Fact]
        public async Task GetCars_Success_Test()
        {
            var _repository = new CarRepository(new CarCatalogContext(opt));

            var carParameters = new CarParameters
            {
                PageNumber = 1,
                PageSize = 5
            };

            // Act
            var cars = _repository.GetCars(carParameters);

            // Assert
            Assert.Equal(carParameters.PageSize, cars.Count());
        }

        [Fact]
        public async Task GetCar_Success_Test()
        {
            var _repository = new CarRepository(new CarCatalogContext(opt));

            // Act
            var car = await _repository.GetCar(2);

            // Assert
            Assert.Equal("Green", car.Color);
        }
    }
}
