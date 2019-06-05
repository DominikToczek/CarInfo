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
	public partial class NewCarPage : ContentPage
	{
		public NewCarPage ()
		{
			InitializeComponent ();
		}

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BrandEntry.Text) 
                || string.IsNullOrEmpty(ModelEntry.Text) 
                || string.IsNullOrEmpty(EngineEntry.Text) 
                || string.IsNullOrEmpty(MileageEntry.Text) 
                || string.IsNullOrEmpty(FuelTypeEntry.Text)
                || string.IsNullOrEmpty(FuelSizeEntry.Text))
            {
                return;
            }

            var car = new Car()
            {
                Brand = BrandEntry.Text,
                Model = ModelEntry.Text,
                Engine = EngineEntry.Text,
                Mileage = Convert.ToInt32(MileageEntry.Text),
                FuelType = FuelTypeEntry.Text,
                FuelTankSize = Convert.ToInt32(FuelSizeEntry.Text)
            };
            var a0 = car;
            var a1 = App.LocalDatabase;
            var a2 = a1.SaveItem(a0);
            await App.LocalDatabase.SaveItem(car);
            await DisplayAlert("New car", $"{car.Brand} {car.Model} has been added to your car list.", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}