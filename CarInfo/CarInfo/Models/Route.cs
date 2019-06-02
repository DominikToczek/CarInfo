using System;
using System.Collections.Generic;
using System.Text;

namespace CarInfo.Models
{
    public class Route
    {
        public int ID { get; set; }
        public DateTime Duration { get; set; }
        public string Distance { get; set; }
        public int carID { get; set; }
    }
}
