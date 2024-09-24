﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entity
{
    public class CarEntity
    {
        [Key]
        public required string VIN { get; set; }
        public required string Make { get; set; }
        public required string Model { get; set; }
        public required int Mileage { get; set; }
        public required string Color { get; set; }
        public required int CreatedAt { get; set; }
    }
}