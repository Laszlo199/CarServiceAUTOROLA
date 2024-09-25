using System.ComponentModel.DataAnnotations;

namespace WebApi.Dtos
{
    public class CarDto
    {
        [Required]
        public string VIN { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public int Mileage { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
