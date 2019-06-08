using System;
using System.Collections.Generic;
using System.Text;
using CarInfo.Interfaces;

namespace CarInfo.Models
{
    public class Route : ISqlite
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Distance { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int CarID { get; set; }
    }
}
