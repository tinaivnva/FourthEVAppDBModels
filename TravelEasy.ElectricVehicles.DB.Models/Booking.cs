using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public int UsertId { get; set; }
        public int CarId { get; set; } 
        public DateTime FromDate {get; set; }
        public DateTime ToDate { get; set; }

    }
}
