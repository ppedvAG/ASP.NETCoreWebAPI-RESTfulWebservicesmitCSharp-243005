using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace VehicleApi.Models
{
    // Dto = Data Transfer Object
    public class AutoResponseDto : AutoDto
    {
        public long Id { get; set; }

    }

    public class AutoDto
    {
        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Fuel { get; set; }

        [Required, Range(45, 450)]
        public int TopSpeed { get; set; }

        [Required]
        public KnownColor Color { get; set; }

        public string? ColorString { get; set; }
    }
}
