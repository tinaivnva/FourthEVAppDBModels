using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class ElectricVehicle
    {
        [Key] 
        public int CarId { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int HorsePowers { get; set; }

        public int Range { get; set; }

        public decimal PricePerDay { get; set; }

        [ForeignKey("Category")]
        public string Category { get; set; }

        public string Image { get; set; }

        Category category { get; set; }
    }
}