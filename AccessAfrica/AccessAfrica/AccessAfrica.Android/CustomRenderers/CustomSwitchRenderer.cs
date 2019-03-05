using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessAfrica.Droid.CustomRenderers;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Switch), typeof(CustomSwitchRenderer))]
namespace AccessAfrica.Droid.CustomRenderers
{
    class CustomSwitchRenderer : SwitchRenderer
    {
        public CustomSwitchRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Switch> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ThumbDrawable.SetColorFilter(Android.Graphics.Color.White, PorterDuff.Mode.SrcAtop);
            }

        }
    }
}