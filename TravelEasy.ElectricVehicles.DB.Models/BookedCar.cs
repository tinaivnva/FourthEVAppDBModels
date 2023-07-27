using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class BookedCar
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        public int UsertId { get; set; }

        [ForeignKey("CarId")]
        public int CarId { get; set; } 
        public DateTime FromDate {get; set; }
        public DateTime ToDate { get; set; }
        
        public User User { get; set; }
        public ElectricVehicle ElectricVehicle { get; set; }
    }
}
