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
	public partial class NewRoutePage : ContentPage
	{
        private Car car;
		public NewRoutePage (Car car)
		{
            this.car = car;
			InitializeComponent ();
		}

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(FromEntry.Text) ||
                String.IsNullOrEmpty(ToEntry.Text) ||
                string.IsNullOrEmpty(DistanceEntry.Text))
            {
                return;
            }

            var route = new Route()
            {
                From = FromEntry.Text,
                To = ToEntry.Text,
                Distance = Convert.ToInt32(DistanceEntry.Text),
                StartTime = StartTimePicker.Time,
                EndTime = EndTimePicker.Time,
                CarID = car.ID
            };

            await App.LocalDatabase.SaveItem(route);
            await DisplayAlert("New route", $"New route has been added to your routes list.", "OK");
            await Navigation.PopToRootAsync();
            // przetestować czy działa
        }
    }
}