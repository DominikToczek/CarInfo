using System;
using System.Collections.Generic;
using System.Text;

namespace CarInfo.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public int Mileage { get; set; }
        public string FuelType { get; set; }
        public int FuelTankSize { get; set; }
    }
}
