using AccessAfrica.Controls;
using AccessAfrica.Models;
using AccessAfrica.Services;
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
        
        //private IList<Country> _getCountries;

        public SendMoney ()
		{
			InitializeComponent ();

            BindingContext = new EntryAndPickerViewModel();
           

        }

       

        private void FlagPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var name = flagPicker.Items[flagPicker.SelectedIndex];
           // var selectedCountry = GetCountries().Single(x => x.Name == name);
            //imageSource2.Source = selectedCountry.Image;
        }


        //currency List

        //private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var currency = picker.Items[picker.SelectedIndex];
        //    var selectedCurrency = GetCountries().Single(x => x.Currency == currency);
        //    imageSource.Source = selectedCurrency.Image;


        //}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           // flagPicker.Focus();
        }

        private void EntryAndPickerControl_NewSelectedIndex(object sender, EventArgs e)
        {
           
        }

        private void EntryAndPickerControl_ArrowTapped(object sender, EventArgs e)
        {
            picker1.NewPicker.Focus();
            picker1.NewPicker.Unfocus();
        }

        private void EntryAndPickerControl_ArrowTapped_1(object sender, EventArgs e)
        {
            picker2.NewPicker.Focus();
            picker2.NewPicker.Unfocus();
        }

        //private void Picker3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var currency = picker3.Items[picker3.SelectedIndex];
        //    var selectedCurrency = GetCountries().Single(x => x.Currency == currency );
        //    imageSource3.Source = selectedCurrency.Image;
        //}
    }
}