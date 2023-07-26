using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class Category
    {
        [Key]
        public string CategoryName { get; set; }
        public int Id { get; set; }

    }
}
