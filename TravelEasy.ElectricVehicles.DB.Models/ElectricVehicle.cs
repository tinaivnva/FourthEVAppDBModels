namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class ElectricVehicle
    {
        public int Id { get; set; }

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public int HorsePowers { get; set; }

        public int Range { get; set; }

        public decimal PricePerDay { get; set; }
        public bool IsBooked { get; set; }  = false;
        public byte ImageData { get; set; }
    }
}