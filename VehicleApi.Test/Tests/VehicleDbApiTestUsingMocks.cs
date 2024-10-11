using Microsoft.AspNetCore.Mvc;
using Moq;
using VehicleApi.Controllers;
using VehicleApi.Models;
using VehicleManagement.Contracts;
using VehicleManagement.Models;

namespace VehicleApi.Test.Tests
{
    [TestClass]
    public class VehicleDbApiTestUsingMocks
    {
        // Mappers ohne Service Logik Testen
        [TestMethod]
        public async Task GetVehicles_FromController_ReturnsVehicles()
        {

            // Arrange
            var mockService = new Mock<IVehicleService>();
            mockService.Setup(x => x.GetVehicles()).ReturnsAsync(new List<Auto>() {
                new Auto
                {
                    Id = 1,
                    Manufacturer = "Unit Testing",
                }
            });
            var controller = new VehiclesController(mockService.Object);

            // Act
            var response = await controller.GetVehicles(null);
            var result = response.Result as OkObjectResult;

            Assert.IsNotNull(result, "Expected non-null result");
            Assert.IsNotNull(result.Value, "Expected value of result not to be null");
            Assert.IsInstanceOfType<IEnumerable<AutoDto>>(result.Value, "Expected value of result to be IEnumerable<AutoDto>>");

            var vehicles = (IEnumerable<AutoDto>)result.Value;
            Assert.AreEqual(1, vehicles.Count(), "Expected same number of vehicles");
        }
    }
}