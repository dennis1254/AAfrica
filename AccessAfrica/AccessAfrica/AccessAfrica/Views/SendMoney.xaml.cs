using AccessAfrica.Models;
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
	public partial class SendMoney : ContentPage
	{
        private IList<Currency> _getCurrencies;
        private IList<Currency> _getCountries;

        public SendMoney ()
		{
			InitializeComponent ();

            _getCurrencies = GetCurrencies();

            _getCountries = GetCountries();

            foreach (var currency in _getCurrencies)
                picker.Items.Add(currency.Name);

            foreach (var currency in _getCurrencies)
                picker3.Items.Add(currency.Name);

            foreach (var country in _getCountries)
                flagPicker.Items.Add(country.Name);


        }

        //country
        private IList<Currency> GetCountries()
        {
            return new List<Currency>
            {
                new Currency{Name = "Nigeria" , Image="NGN.png"},
                new Currency{Name = "Ghana" , Image="NGN.png"}
            };
        }

        private void FlagPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = flagPicker.Items[flagPicker.SelectedIndex];
            var selectedCurreny = GetCountries().Single(x => x.Name == name);
            imageSource2.Source = selectedCurreny.Image;
        }


        //currency List
        private IList<Currency> GetCurrencies()
        {
            return new List<Currency>
            {
                new Currency{Name = "NGN" , Image="NGN.png"},
                new Currency{Name = "USD" , Image="NGN.png"}
            };
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker.Items[picker.SelectedIndex];
            var selectedCurreny = GetCurrencies().Single(x => x.Name == name);
            imageSource.Source = selectedCurreny.Image;
            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            flagPicker.Focus();
        }

        private void Picker3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = picker3.Items[picker3.SelectedIndex];
            var selectedCurrency = GetCurrencies().Single(x => x.Name == name);
            imageSource3.Source = selectedCurrency.Image;
        }
    }
}