﻿using System;
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
	public partial class RoutesPage : ContentPage
	{
		public RoutesPage()
		{
			InitializeComponent ();
		}

        private async Task RefreshListView()
        {
            var routes = await App.LocalDatabase.GetAll<Route>();
            routesListView.ItemsSource = routes;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await RefreshListView();
        }

        private async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewRouteCarSelectPage());
        }
    }
}