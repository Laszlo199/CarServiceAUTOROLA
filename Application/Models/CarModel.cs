using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
