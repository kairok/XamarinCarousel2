using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Carousel3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.topPanel);
           // SetSupportActionBar(toolbar);
            SupportActionBar.Title = "Nara Drive";

           var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);
            ImageAdapter adapter = new ImageAdapter(this);
              viewPager.Adapter = adapter;

        }
    }
}