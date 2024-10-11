using System.Drawing;
using VehicleApi.Models;
using VehicleManagement.Models;

namespace VehicleApi.Mappers
{
    /**
     * Wir wollen verhindern, dass das Entity-Objekt (Auto) direkt in der WebAPI Schicht verwendet wird.
     * Die WebAPI Schicht sollte nur sog. "data transfer objects" (AutoDto) verwenden.
     * Der Mapper kann darüber hinaus Abhängigkeiten auflösen und auch Felder konvertieren oder berechnen, 
     * die evtl. in der DB nicht vorkommen.
     * 
     * Weitere Alternativen: AutoMapper Package oder T4 Templates um Code zu generieren.
     */
    public static class VehicleMapper
    {
        public static AutoResponseDto ToDto(this Auto vehicle)
        {
            return new AutoResponseDto
            {
                Id = vehicle.Id,
                Manufacturer = vehicle.Manufacturer,
                Model = vehicle.Model,
                Type = vehicle.Type,
                Fuel = vehicle.Fuel,
                TopSpeed = vehicle.TopSpeed,
                Color = vehicle.Color,
                ColorString = vehicle.Color.ToString()
            };
        }

        public static Auto ToEntity(this AutoDto vehicle)
        {
            Enum.TryParse(vehicle.ColorString, out KnownColor color);
            return new Auto
            {
                Manufacturer = vehicle.Manufacturer,
                Model = vehicle.Model,
                Type = vehicle.Type,
                Fuel = vehicle.Fuel,
                TopSpeed = vehicle.TopSpeed,
                Color = color
            };
        }
    }
}
