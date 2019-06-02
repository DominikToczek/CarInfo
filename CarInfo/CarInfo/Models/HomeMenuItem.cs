using System;
using System.Collections.Generic;
using System.Text;

namespace CarInfo.Models
{
    public enum MenuItemType
    {
        Home,
        Cars,
        Routes,
        Statistics,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
