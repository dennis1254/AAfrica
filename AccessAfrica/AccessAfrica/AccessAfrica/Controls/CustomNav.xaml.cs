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
	public partial class CustomNav : ContentView
	{
        public event EventHandler BackTapped;

        public string NavTitle
        {
            get => navTitle.Text ;
            set => navTitle.Text  = value;
        }
        public CustomNav ()
		{
			InitializeComponent ();
		}

        private  void Back_Tapped(object sender, EventArgs e)
        {
            BackTapped.Invoke(this, e);
        }
    }
}