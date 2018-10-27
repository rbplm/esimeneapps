﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Webkit;

namespace esimeneapps
{
    [Activity(Label = "vewViewLayout")]
    public class vewViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.vewViewLayout);

            var webView = FindViewById<WebView>(Resource.Id.webView1);
            webView.LoadUrl("http://www.google.com");
            // Create your application here
        }
       
    }
}