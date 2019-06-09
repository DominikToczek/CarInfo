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
	public partial class CostsPage : ContentPage
	{
		public CostsPage ()
		{
			InitializeComponent ();
		}
        private async Task RefreshListView()
        {
            var cars = await App.LocalDatabase.GetAll<Fuel>();
            FuelListView.ItemsSource = cars;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshListView();
        }

        private void FuelListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new CostDetailsPage((Fuel)e.Item));

            ((ListView)sender).SelectedItem = null;
        }
    }
}