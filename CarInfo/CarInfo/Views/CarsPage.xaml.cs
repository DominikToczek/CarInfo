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
	public partial class CarsPage : ContentPage
	{
		public CarsPage ()
		{
			InitializeComponent ();
		}
        private async Task RefreshListView()
        {
            var a1 = App.LocalDatabase;
            var a2 = a1.GetAll<Car>();
            var cars = await App.LocalDatabase.GetAll<Car>();
            CarListView.ItemsSource = cars;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshListView();
        }

        private void AddItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewCarPage());
        }
    }
}