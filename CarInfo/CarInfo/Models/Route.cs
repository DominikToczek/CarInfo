using System;
using System.Collections.Generic;
using System.Text;

namespace CarInfo.Models
{
    public class Route
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public DateTime Duration { get; set; }
        public string Distance { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int carID { get; set; }
    }
}
