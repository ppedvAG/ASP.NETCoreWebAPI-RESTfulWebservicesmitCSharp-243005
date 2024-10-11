using Bogus;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using VehicleManagement.Models;

namespace VehicleManagement.Data
{
    public class Seed
    {
        public const int VehicleCount = 100;

        public static Seed Instance = new();

        private readonly Faker _faker = new Faker();
        private readonly int ColorCount = Enum.GetNames(typeof(KnownColor)).Length;

        private Seed()
        {
        }

        public void InitData(ModelBuilder modelBuilder)
        {
            // Erzeuge 100 zufaellige Autos
            var vehicles = Enumerable.Range(1, VehicleCount + 1).Select(Generate).ToArray();

            // Vehicles in DB schreiben
            modelBuilder.Entity<Auto>().HasData(vehicles);
        }

        private Auto Generate(int id)
        {
            var color = (KnownColor)_faker.Random.Int(27, ColorCount);
            return new Auto
            {
                Id = id,
                Manufacturer = _faker.Vehicle.Manufacturer(),
                Model = _faker.Vehicle.Model(),
                Type = _faker.Vehicle.Type(),
                Fuel = _faker.Vehicle.Fuel(),
                TopSpeed = _faker.Random.Int(12, 22) * 10,
                Color = color
            };
        }
    }
}
