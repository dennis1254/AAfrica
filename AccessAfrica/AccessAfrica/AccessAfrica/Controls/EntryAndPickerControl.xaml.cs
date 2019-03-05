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
	public partial class EntryAndPickerControl : ContentView
	{
		public EntryAndPickerControl ()
		{
			InitializeComponent ();
		}

        private void Arrow_Tapped(object sender, EventArgs e)
        {

        }
    }
}