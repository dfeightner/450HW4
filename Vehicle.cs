using System.ComponentModel.DataAnnotations;

namespace HW4.Models
{
    public class Vehicle
    {

        public int VehicleId { get; set; }

        public int Mileage { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateReceived { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateSold { get; set; }

        public string VehicleStatus { get; set; }

        public string VIN {  get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }







    }
}
