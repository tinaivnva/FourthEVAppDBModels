using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public string Image { get; set; }

        public Category Category { get; set; }
    }
}