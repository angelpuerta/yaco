using System.ComponentModel.DataAnnotations;

namespace places.Models
{
    public class Coordinate
    {
        [Required]
        public double Latitude { get; }

        [Required]
        public double Longitude { get; }
    }
}