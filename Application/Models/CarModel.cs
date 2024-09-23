using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CarModel
    {
        public required string VIN { get; set; }
        public required string Make { get; set; }
        public required string Model { get; set; }
        public required int Mileage { get; set; }
        public required string Color { get; set; }
        public required DateTime CreatedAt { get; set; }
    }
}
