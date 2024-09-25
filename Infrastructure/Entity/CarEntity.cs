using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entity
{
    public class CarEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

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