using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessAfrica.Custom;
using AccessAfrica.Droid.CustomRenderers;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer2))]
namespace AccessAfrica.Droid.CustomRenderers
{
    class CustomPickerRenderer2 : PickerRenderer
    {
        public CustomPickerRenderer2(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundResource(Android.Resource.Color.Transparent);

            }
        }
    }
}