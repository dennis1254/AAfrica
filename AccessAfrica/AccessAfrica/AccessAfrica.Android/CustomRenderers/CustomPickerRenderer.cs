using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessAfrica.Custom;
using AccessAfrica.Droid.CustomRenderers;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Picker), typeof(CustomPickerRenderer))]
namespace AccessAfrica.Droid.CustomRenderers
{
    class CustomPickerRenderer : PickerRenderer
    {
       
        public CustomPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

          

            if (Control != null)
            {
               Control.SetBackgroundResource(Android.Resource.Color.Transparent);

                Control.Gravity = GravityFlags.CenterHorizontal;

            }
        }
    }
}