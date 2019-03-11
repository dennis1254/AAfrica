using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessAfrica.Controls
{

   
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomButton : ContentView
	{
        public event EventHandler ButtonClicked;
        public string ButtonText
        {
            get => customButton.Text;
            set => customButton.Text = value;
        }
		public CustomButton ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            ButtonClicked.Invoke(this, e);
        }
    }
}