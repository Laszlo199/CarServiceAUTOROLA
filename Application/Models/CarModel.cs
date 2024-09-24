using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class CarModel
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
        public int CreatedAt { get; set; }
    }
}
