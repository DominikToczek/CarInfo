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
	public partial class RouteDetailsPage : ContentPage
	{
        private Route route;
        public RouteDetailsPage (Route route)
		{
            this.route = route;
			InitializeComponent ();
            FromLabel.Text = route.From;
            ToLabel.Text = route.To;
            DistanceLabel.Text = route.Distance.ToString();
            StartTimeLabel.Text = route.StartTime.ToString();
            EndTimeLabel.Text = route.EndTime.ToString();
		}
	}
}