using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessAfrica.Droid.CustomRenderers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace AccessAfrica.Droid.CustomRenderers
{
    class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {

                Control.SetBackgroundResource(Android.Resource.Color.Transparent);
                //Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(Android.Graphics.Color.LightGray);
            }
        }
    }
}