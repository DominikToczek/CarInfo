using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarInfo.Models;

namespace CarInfo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CostDetailsPage : ContentPage
	{
        private Fuel fuel;
		public CostDetailsPage (Fuel fuel)
		{
            this.fuel = fuel;
			InitializeComponent ();
            FuelTypeLabel.Text = fuel.FuelType;
            QuantityLabel.Text = fuel.Quantity.ToString();
            PriceLabel.Text = fuel.Price.ToString();
            DateLabel.Text = fuel.Date.ToString();
		}
	}
}