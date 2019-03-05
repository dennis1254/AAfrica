using AccessAfrica.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AccessAfrica
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Intro()) {
            //    BarBackgroundColor = Color.FromHex("#001e5a"),
            //    BarTextColor = Color.FromHex("#FFFFFF")
            //};
            MainPage = new NavigationPage(new LandingPage())
            {
                BarBackgroundColor = Color.FromHex("#001e5a"),
                BarTextColor = Color.FromHex("#FFFFFF")


            };
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
