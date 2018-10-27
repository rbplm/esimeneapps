using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace esimeneapps
{
    [Activity(Label = "secondactivity")]
    public class secondactivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.secondlayout);

            // Create your application here
            var textView = FindViewById<TextView>(Resource.Id.textView1);

            var mytext = Intent.GetStringExtra("Mydata") ?? "Data not available";

            textView.Text = mytext;

        }
    }
}