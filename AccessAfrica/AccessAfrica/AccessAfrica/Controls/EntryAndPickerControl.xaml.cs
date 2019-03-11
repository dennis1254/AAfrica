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
    public partial class EntryAndPickerControl : ContentView
    {
        private IList<Country> _getCountries;

        public event EventHandler NewSelectedIndex;

        public event EventHandler ArrowTapped;

        public Picker NewPicker { get => picker; }

        public int IndexSelected
        {
            get => picker.SelectedIndex;
            set => picker.SelectedIndex = value;
        }

 

        public IList ItemSource
        {
            get { return (IList)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        public static readonly BindableProperty ItemSourceProperty = BindableProperty.Create(
        "ItemSource", typeof(IList), typeof(EntryAndPickerControl),default(IList),BindingMode.TwoWay);

        //SelectedItem
        public string SelectedItem
        {
            get { return (string)GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(
        "SelectedItem", typeof(string), typeof(EntryAndPickerControl), default(string), BindingMode.TwoWay);

        //NewImageSource
        public ImageSource NewImageSource 
        {
            get { return (ImageSource)GetValue(NewImageSourceProperty); }
            set { SetValue(NewImageSourceProperty, value); }
        }

        public static readonly BindableProperty NewImageSourceProperty = BindableProperty.Create("NewImageSource", typeof(ImageSource), typeof(EntryAndPickerControl), default(ImageSource), BindingMode.TwoWay);

        //PlaceHolder
        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }

        public static readonly BindableProperty PlaceHolderProperty = BindableProperty.Create("PlaceHolder", typeof(string), typeof(EntryAndPickerControl), default(string),BindingMode
            .TwoWay);

        public string NewLabel
        {
            get => pickerLabel.Text;
            set => pickerLabel.Text= value;
            
        }

        public string Currency
        {
            
            get;
            set;
        }

        public EntryAndPickerControl ()
		{
            
			InitializeComponent ();
            picker.SetBinding(Picker.ItemsSourceProperty, new Binding("ItemSource", source: this));
            picker.SetBinding(Picker.SelectedItemProperty, new Binding("SelectedItem", source: this));
            pickerEntry.SetBinding(Entry.PlaceholderProperty, new Binding("PlaceHolder", source: this));
   
        }

        //private void Arrow_Tapped(object sender, EventArgs e)
        //{
        //    ArrowTapped.Invoke(this, e);
        //}

        

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewSelectedIndex.Invoke(this, e);
            var name = picker.Items[picker.SelectedIndex];
            var selectedCountry = _getCountries.Single(x => x.Currency == name);
            countryFlag.Source = selectedCountry.Image;
            Currency = name;

            
        }

       
    }
}