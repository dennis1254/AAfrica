using AccessAfrica.Models;
using AccessAfrica.Services;
using AccessAfrica.ViewModels;
using System;
using System.Collections;
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
        private IList<Country> _getCountries;

        public event EventHandler NewSelectedIndex;

        public IList NewItemSource
        {
            get => picker.ItemsSource;
            set => picker.ItemsSource = value;
        }


       
        public CustomPicker()
		{
			InitializeComponent ();
            var service = new Service();

            BindingContext = new EntryAndPickerViewModel();
            //_getCountries = service.GetCountries();
            //BindingContext = new Service();
            //foreach (var country in _getCountries) picker.Items.Add(country.Name);

		}

        private void Flag_Tapped(object sender, EventArgs e)
        {
            picker.Focus();
            picker.Unfocus();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSelectedIndex.Invoke(this, e);
            var name = picker.Items[picker.SelectedIndex];
            var selectedCountry = _getCountries.Single(x => x.Name == name);
            countryFlag.Source = selectedCountry.Image;
        }
    }
}