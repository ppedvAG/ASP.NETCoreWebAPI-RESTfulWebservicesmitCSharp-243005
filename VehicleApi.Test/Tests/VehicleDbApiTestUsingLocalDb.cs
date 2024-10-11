using Microsoft.AspNetCore.Mvc;
using VehicleApi.Controllers;
using VehicleApi.Models;
using VehicleManagement.Data;
using VehicleManagement.Services;

namespace VehicleApi.Test.Tests
{
    [TestClass]
    public class VehicleDbApiTestUsingLocalDb
    {
        private readonly VehicleDbContext _context = new TestDatabase().CreateDbContext();

        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestCleanup]
        public void TestCleanup()
        {
            _context.Dispose();
        }

        [TestMethod]
        public async Task GetVehicles_FromService_ReturnsVehicles()
        {
            // Arrange
            var expectedCount = Seed.VehicleCount;
            var service = new VehicleService(_context);

            // Act
            var result = await service.GetVehicles();

            // Assert
            Assert.IsNotNull(result, "Expected non-null result");
            Assert.AreEqual(expectedCount, result.Count(), "Expected same number of vehicles");
        }

        // Die Code Coverage ist hier hoeher weil wir auch die Mapping Klassen abtesten
        [TestMethod]
        public async Task GetVehicles_FromController_ReturnsVehicles()
        {
            // Arrange
            var expectedCount = Seed.VehicleCount;
            var service = new VehicleService(_context);
            var controller = new VehiclesController(service);

            // Act
            var response = await controller.GetVehicles(null);
            var result = response.Result as OkObjectResult;

            // Assert
            Assert.IsNotNull(result, "Expected non-null result");
            Assert.IsNotNull(result.Value, "Expected value of result not to be null");
            Assert.IsInstanceOfType<IEnumerable<AutoDto>>(result.Value, "Expected value of result to be IEnumerable<AutoDto>>");

            var vehicles = (IEnumerable<AutoDto>)result.Value;
            Assert.AreEqual(expectedCount, vehicles.Count(), "Expected same number of vehicles");
        }
    }
}