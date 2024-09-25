using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entity
{
    public class CarEntity
    {
        [Key]
        public int Id { get; set; }
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}