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
	public partial class NewRouteCarSelectPage : ContentPage
	{
		public NewRouteCarSelectPage ()
		{
			InitializeComponent ();
		}
        private async Task RefreshListView()
        {
            var cars = await App.LocalDatabase.GetAll<Car>();
            CarListView.ItemsSource = cars;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshListView();
        }

        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new NewRoutePage((Car)e.Item));
            
            ((ListView)sender).SelectedItem = null;
        }
    }
}