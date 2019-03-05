using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using AccessAfrica.Models;
using Prism.Navigation;

namespace AccessAfrica.ViewModels
{
    public class LandingPageViewModel : BaseViewModel
    {
        public ObservableCollection<Slide> Slides { get; }

        public LandingPageViewModel()
        {
            Slides = new ObservableCollection<Slide>(new[]
            {
                new Slide ("Image1st.png", "Send money to family and friends across the globe."),
                new Slide ("Image2nd.png", "Stress free from your mobile device to any destination."),
                new Slide ("Image3rd.png", "Transactions can be carried out from any bank account.")
            });
        }
    }
}
