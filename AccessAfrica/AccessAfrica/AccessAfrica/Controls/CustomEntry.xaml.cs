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
    public partial class CustomEntry : ContentView
    {

        public string NewPlaceHolder
        {
            get => mainEntry.Placeholder;
            set => mainEntry.Placeholder=value;
        }

        public string NewLabel
        {
            get => entryLabel.Text ;
            set => entryLabel.Text = value;
        }

        public Color EntryBackgroundColor
        {
            get => mainFrame.BackgroundColor;
            set => mainFrame.BackgroundColor = value;
        }


        public CustomEntry()
        {
            InitializeComponent();
        }
    }
}