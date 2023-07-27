using System.ComponentModel.DataAnnotations;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
