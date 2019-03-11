using AccessAfrica.Models;
using AccessAfrica.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace AccessAfrica.ViewModels
{
    public class EntryAndPickerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Command Selected { get; }

        string currency = string.Empty;

        Service service = new Service();

        public IList Countries => CountryNames();
        public IList Currencies => CurrencyNames();
        public int CurrencySelectIndex { get; set; }

        public string TestPlaceholder
        {
            get => placeholder;
            set => placeholder = value;
        }

        public string placeholder = "Banker";


        //public string Image => ImageCurrency();
        public EntryAndPickerViewModel()
        {
            Selected = new Command(SelectedCurrency);
        }

       

        public string Currency
        {
            get => currency;
            set
            {
                if (currency == value) return;

                currency = value;

                OnPropertyChanged(nameof(Currency));
                OnPropertyChanged(nameof(ExchangeCurrency));
                OnPropertyChanged(nameof(CurrencySelectIndex));
            }
        }

        public string ExchangeCurrency => Currency;

        private void OnPropertyChanged(string currency)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(currency));
        }

        private IList CountryNames()
        {
            var country = new List<string>();
            foreach (var ctry in service.GetCountries())
            {
                country.Add(ctry.Name);
            }

            return country;
        }

        private IList CurrencyNames()
        {
            var currency = new List<string>();
            foreach (var ctry in service.GetCountries())
            {
                currency.Add(ctry.Currency);
            }

            return currency;
        }

        private string ImageCurrency(string currency)
        {
            var image = service.GetCountries().Single(x => x.Currency == currency).Image;
            return image;
        }

        void SelectedCurrency()
        {
            
        }
    }
}
