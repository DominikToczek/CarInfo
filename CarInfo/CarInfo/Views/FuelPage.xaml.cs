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
    public partial class FuelPage : ContentPage
    {
        public FuelPage()
        {
            InitializeComponent();
            var pickerSourceList = new List<string>()
            {
                "Petrol",
                "Diesel",
                "LPG"
            };
            FuelTypePicker.ItemsSource = pickerSourceList;
        }
        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FuelTypePicker.SelectedItem.ToString())
                || string.IsNullOrEmpty(QuantityEntry.Text)
                || string.IsNullOrEmpty(PriceEntry.Text))
            {
                return;
            }

            var fuel = new Fuel()
            {
                FuelType = FuelTypePicker.SelectedItem.ToString(),
                Quantity = Convert.ToInt32(QuantityEntry.Text),
                Price = Convert.ToInt32(PriceEntry.Text),
                Date = DatePicker.Date
            };

            await App.LocalDatabase.SaveItem(fuel);
            await DisplayAlert("Add fuel", $"New fuel cost has been saved.", "OK");
            await Navigation.PopToRootAsync();
        }
    }
}