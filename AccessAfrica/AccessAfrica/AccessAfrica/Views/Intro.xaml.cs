using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessAfrica.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Intro : ContentPage
	{
		public Intro ()
		{
			InitializeComponent ();

            OnAppearing();

    
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ImageScale();


        }

        public async void ImageScale()
        {
            imageScale.Source = "AccessIntro2.png";
            await Task.Delay(200);
            imageScale.Opacity = 0.6;
            await imageScale.ScaleTo(4, 100, CustomEase());
            await Task.Delay(99);
            imageScale.Opacity = 0.5;
            imageScale.Source = "AccessIntro.png";        
            await imageScale.ScaleTo(12, 100, CustomEase());
            await Task.Delay(480);
            await imageScale.FadeTo(0,50, Easing.SinIn);
            await Task.Delay(2000);
            
        }

         Easing CustomEase ()
        {
             return new Easing(t => (int)(1 * t) / 5.0);
        }
    }
}