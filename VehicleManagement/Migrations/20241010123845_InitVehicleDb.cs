using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VehicleManagement.Migrations
{
    /// <inheritdoc />
    public partial class InitVehicleDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopSpeed = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleId);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleId", "Color", "Fuel", "Manufacturer", "Model", "TopSpeed", "Type" },
                values: new object[,]
                {
                    { 1L, 162, "Gasoline", "Bentley", "Roadster", 200, "Passenger Van" },
                    { 2L, 89, "Hybrid", "Jeep", "Ranchero", 160, "Wagon" },
                    { 3L, 94, "Gasoline", "Maserati", "Aventador", 120, "Sedan" },
                    { 4L, 139, "Hybrid", "Jaguar", "Volt", 120, "Minivan" },
                    { 5L, 88, "Hybrid", "Volvo", "Aventador", 140, "Sedan" },
                    { 6L, 86, "Electric", "Nissan", "Element", 180, "Sedan" },
                    { 7L, 155, "Hybrid", "Land Rover", "Camry", 190, "Extended Cab Pickup" },
                    { 8L, 154, "Gasoline", "Fiat", "Expedition", 120, "Minivan" },
                    { 9L, 159, "Electric", "Dodge", "Countach", 160, "Coupe" },
                    { 10L, 115, "Gasoline", "Toyota", "V90", 160, "Crew Cab Pickup" },
                    { 11L, 132, "Electric", "Mini", "Volt", 130, "Coupe" },
                    { 12L, 70, "Hybrid", "Dodge", "LeBaron", 180, "Passenger Van" },
                    { 13L, 69, "Hybrid", "Kia", "Cruze", 180, "Extended Cab Pickup" },
                    { 14L, 73, "Electric", "Ford", "Fiesta", 160, "Hatchback" },
                    { 15L, 45, "Electric", "Mazda", "Grand Caravan", 210, "Hatchback" },
                    { 16L, 94, "Electric", "Ferrari", "CTS", 160, "Wagon" },
                    { 17L, 136, "Diesel", "Ferrari", "911", 170, "Cargo Van" },
                    { 18L, 130, "Gasoline", "Ferrari", "911", 170, "Convertible" },
                    { 19L, 110, "Gasoline", "Hyundai", "1", 120, "Wagon" },
                    { 20L, 154, "Diesel", "Bentley", "Ranchero", 180, "Crew Cab Pickup" },
                    { 21L, 47, "Electric", "Mercedes Benz", "XC90", 120, "Convertible" },
                    { 22L, 125, "Hybrid", "Mini", "Ranchero", 170, "Cargo Van" },
                    { 23L, 145, "Hybrid", "Smart", "Jetta", 140, "Convertible" },
                    { 24L, 59, "Diesel", "Mini", "Explorer", 220, "Sedan" },
                    { 25L, 47, "Diesel", "Bentley", "Expedition", 160, "Passenger Van" },
                    { 26L, 143, "Hybrid", "Lamborghini", "Fiesta", 150, "Hatchback" },
                    { 27L, 38, "Gasoline", "Mini", "CTS", 130, "Hatchback" },
                    { 28L, 58, "Gasoline", "Tesla", "Grand Cherokee", 150, "Passenger Van" },
                    { 29L, 123, "Hybrid", "Fiat", "LeBaron", 160, "Extended Cab Pickup" },
                    { 30L, 164, "Hybrid", "Smart", "Accord", 130, "Sedan" },
                    { 31L, 93, "Electric", "Kia", "Civic", 190, "Wagon" },
                    { 32L, 174, "Gasoline", "Hyundai", "Model T", 180, "Minivan" },
                    { 33L, 108, "Electric", "Ford", "El Camino", 170, "Wagon" },
                    { 34L, 80, "Hybrid", "Hyundai", "Model S", 150, "Passenger Van" },
                    { 35L, 117, "Diesel", "Cadillac", "Charger", 200, "Cargo Van" },
                    { 36L, 42, "Hybrid", "Ford", "Civic", 180, "Extended Cab Pickup" },
                    { 37L, 127, "Diesel", "Land Rover", "Element", 200, "Hatchback" },
                    { 38L, 175, "Diesel", "Mercedes Benz", "Jetta", 190, "Minivan" },
                    { 39L, 30, "Hybrid", "Chevrolet", "Model 3", 180, "Convertible" },
                    { 40L, 86, "Hybrid", "Maserati", "El Camino", 170, "Passenger Van" },
                    { 41L, 38, "Hybrid", "Lamborghini", "Sentra", 220, "Minivan" },
                    { 42L, 144, "Electric", "Land Rover", "Altima", 210, "Wagon" },
                    { 43L, 170, "Gasoline", "Hyundai", "Expedition", 200, "Wagon" },
                    { 44L, 97, "Gasoline", "Honda", "Grand Cherokee", 130, "Convertible" },
                    { 45L, 86, "Diesel", "Mercedes Benz", "Alpine", 190, "Convertible" },
                    { 46L, 164, "Hybrid", "Ferrari", "Grand Cherokee", 130, "Crew Cab Pickup" },
                    { 47L, 66, "Gasoline", "Smart", "Countach", 190, "Minivan" },
                    { 48L, 63, "Electric", "Chrysler", "Element", 210, "Wagon" },
                    { 49L, 159, "Hybrid", "Rolls Royce", "Wrangler", 220, "Extended Cab Pickup" },
                    { 50L, 152, "Gasoline", "Jaguar", "Altima", 210, "Hatchback" },
                    { 51L, 91, "Electric", "Chrysler", "Civic", 160, "Convertible" },
                    { 52L, 119, "Diesel", "Toyota", "CTS", 190, "Hatchback" },
                    { 53L, 143, "Gasoline", "Kia", "Fortwo", 180, "Crew Cab Pickup" },
                    { 54L, 159, "Gasoline", "Chevrolet", "Escalade", 200, "Wagon" },
                    { 55L, 147, "Diesel", "Smart", "Aventador", 160, "Sedan" },
                    { 56L, 38, "Hybrid", "Nissan", "F-150", 200, "Convertible" },
                    { 57L, 109, "Gasoline", "Porsche", "Alpine", 120, "Passenger Van" },
                    { 58L, 154, "Electric", "Bentley", "Silverado", 170, "Coupe" },
                    { 59L, 150, "Gasoline", "Kia", "Expedition", 160, "Wagon" },
                    { 60L, 148, "Gasoline", "Maserati", "Corvette", 210, "Coupe" },
                    { 61L, 141, "Diesel", "Ford", "2", 130, "Sedan" },
                    { 62L, 46, "Electric", "Polestar", "Fiesta", 150, "SUV" },
                    { 63L, 171, "Hybrid", "Volkswagen", "Alpine", 210, "Hatchback" },
                    { 64L, 156, "Hybrid", "Honda", "PT Cruiser", 150, "Coupe" },
                    { 65L, 150, "Electric", "Jeep", "Roadster", 190, "Extended Cab Pickup" },
                    { 66L, 119, "Hybrid", "Tesla", "Escalade", 170, "Passenger Van" },
                    { 67L, 155, "Diesel", "Honda", "PT Cruiser", 180, "Crew Cab Pickup" },
                    { 68L, 123, "Gasoline", "Mini", "Beetle", 160, "Convertible" },
                    { 69L, 79, "Electric", "BMW", "CX-9", 120, "Convertible" },
                    { 70L, 105, "Hybrid", "Rolls Royce", "Altima", 120, "Sedan" },
                    { 71L, 156, "Electric", "Polestar", "XTS", 220, "SUV" },
                    { 72L, 128, "Diesel", "Smart", "Accord", 140, "Cargo Van" },
                    { 73L, 128, "Electric", "Mercedes Benz", "CTS", 120, "Convertible" },
                    { 74L, 175, "Gasoline", "Audi", "XC90", 180, "Passenger Van" },
                    { 75L, 163, "Hybrid", "Lamborghini", "Escalade", 180, "Extended Cab Pickup" },
                    { 76L, 129, "Hybrid", "Volkswagen", "XC90", 200, "Sedan" },
                    { 77L, 52, "Gasoline", "Dodge", "Jetta", 120, "Minivan" },
                    { 78L, 98, "Diesel", "Chevrolet", "Explorer", 190, "Cargo Van" },
                    { 79L, 47, "Diesel", "Mini", "Accord", 130, "Coupe" },
                    { 80L, 46, "Electric", "Kia", "Escalade", 160, "Crew Cab Pickup" },
                    { 81L, 44, "Electric", "Bentley", "Beetle", 130, "Convertible" },
                    { 82L, 91, "Gasoline", "Volkswagen", "Spyder", 210, "Cargo Van" },
                    { 83L, 40, "Electric", "Volvo", "Volt", 190, "Cargo Van" },
                    { 84L, 107, "Diesel", "Audi", "Malibu", 140, "Crew Cab Pickup" },
                    { 85L, 131, "Hybrid", "BMW", "Land Cruiser", 140, "Minivan" },
                    { 86L, 67, "Hybrid", "Tesla", "XTS", 210, "Passenger Van" },
                    { 87L, 166, "Diesel", "Tesla", "ATS", 200, "Convertible" },
                    { 88L, 37, "Electric", "Tesla", "Sentra", 130, "Hatchback" },
                    { 89L, 77, "Electric", "Nissan", "V90", 160, "Convertible" },
                    { 90L, 103, "Hybrid", "Honda", "A8", 170, "Cargo Van" },
                    { 91L, 80, "Diesel", "Maserati", "CX-9", 160, "Minivan" },
                    { 92L, 113, "Gasoline", "Chrysler", "Challenger", 140, "Minivan" },
                    { 93L, 108, "Hybrid", "Bugatti", "Escalade", 150, "Crew Cab Pickup" },
                    { 94L, 142, "Diesel", "Maserati", "Prius", 220, "Passenger Van" },
                    { 95L, 63, "Hybrid", "Honda", "Wrangler", 170, "Hatchback" },
                    { 96L, 32, "Diesel", "Mini", "Silverado", 130, "Convertible" },
                    { 97L, 162, "Hybrid", "Ford", "Golf", 180, "Crew Cab Pickup" },
                    { 98L, 174, "Hybrid", "Bentley", "Escalade", 140, "Cargo Van" },
                    { 99L, 133, "Gasoline", "Ferrari", "Challenger", 120, "Cargo Van" },
                    { 100L, 147, "Electric", "Rolls Royce", "Civic", 210, "Cargo Van" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
