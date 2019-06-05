using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarInfo.Views;
using CarInfo.Data;
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
                    var fileHelper = DependencyService.Get<IFileHelper>();
                    var path = fileHelper.GetLocalFilePath("CarInfo.database");
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
    }
}
