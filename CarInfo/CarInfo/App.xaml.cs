using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarInfo.Views;
using CarInfo.Data
using CarInfo.Interfaces;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CarInfo
{
    public partial class App : Application
    {
        private static LocalDatabase localDatabase;
        public static LocalDatabase LocalDatabase
        {
            get
            {
                if (localDatabase == null)
                {
                    var file = DependencyService.Get<IFile>();
                    var path = file.GetLocalFilePath("app.database");
                    localDatabase = new LocalDatabase(path);
                }
                return localDatabase;
            }
        }
        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
