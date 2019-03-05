using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AccessAfrica.Droid
{
    [Activity(Label = "Access Africa", MainLauncher = true, NoHistory = true, Theme = "@style/IntroTheme",
     ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var intent = new Intent(this, typeof(MainActivity));

            StartActivity(intent);

            Finish();

            // Create your application here
        }
    }
}