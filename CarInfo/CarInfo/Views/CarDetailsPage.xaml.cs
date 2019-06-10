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
	public partial class CarDetailsPage : ContentPage
	{
        private Car car;
		public CarDetailsPage (Car car)
		{
            this.car = car;
			InitializeComponent ();
            BrandLabel.Text = car.Brand;
            ModelLabel.Text = car.Model;
            EngineLabel.Text = car.Engine;
            MileageLabel.Text = car.Mileage.ToString();
            FuelTypeLabel.Text = car.FuelType;
            FuelSizeLabel.Text = car.FuelTankSize.ToString();
		}
	}
}