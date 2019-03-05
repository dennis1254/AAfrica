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
	public partial class CustomPicker : ContentView
	{
		public CustomPicker ()
		{
			InitializeComponent ();
		}

        private void Flag_Tapped(object sender, EventArgs e)
        {

        }
    }
}