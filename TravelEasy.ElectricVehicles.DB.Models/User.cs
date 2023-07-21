﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        //max and min chars
        public string Password { get; set; }

    }
}
