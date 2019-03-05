
using AccessAfrica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessAfrica.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            BindingContext = new LandingPageViewModel();


           
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(NextKey.Text == "Done")
            {
                Skip_Tapped(sender, e);
                
            }
            carousel.Position++; 

        }

        private async void Skip_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LandingPage2());
        }

        private void Carousel_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            if(carousel.Position == 2)
            {
                NextKey.Text = "Done";
            }

            else
            {
                NextKey.Text = "Next";
            }
        }
    }
}