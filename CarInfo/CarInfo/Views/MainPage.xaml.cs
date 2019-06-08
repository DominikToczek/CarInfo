using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarInfo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            MenuGrid.HeightRequest = height;
        }

        private async void CarsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CarsPage());
        }

        private async void RoutesButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoutesPage());
        }

        private async void CostsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CostsPage());
        }

        private async void FuelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FuelPage());
        }

        private async void StatisticsButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StatisticsPage());
        }

        private void AboutButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
    }
}