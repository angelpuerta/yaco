using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace places.Models
{
    public class Location
    {
        [Required]
        public string Street { get; }

        [Required]
        public string Portal { get; }

        [Required]
        public Coordinate Coordinate{ get; }

#nullable enable
        public string? AdditionalInfo { get; }


    }
}
