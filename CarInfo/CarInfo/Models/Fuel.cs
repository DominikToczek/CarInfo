using System;
using System.Collections.Generic;
using System.Text;
using CarInfo.Interfaces;

namespace CarInfo.Models
{
    public class Fuel : ISqlite
    {
        [SQLite.PrimaryKey, SQLite.AutoIncrement]
        public int ID { get; set; }
        public string FuelType { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
    }
}
