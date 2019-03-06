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
	public partial class VerifyBVN : ContentPage
	{
		public VerifyBVN ()
		{
			InitializeComponent ();
		}

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}