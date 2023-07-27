using System.ComponentModel.DataAnnotations;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class Category
    {
        [Key]
        public string CategoryName { get; set; }
        public int Id { get; set; }

    }
}
