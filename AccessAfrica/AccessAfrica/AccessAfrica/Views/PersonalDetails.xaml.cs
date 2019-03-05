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
	public partial class PersonalDetails : ContentPage
	{
        
		public PersonalDetails ()
		{
			InitializeComponent ();

           
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new PersonalDetails2(),true);
        }
    }
}