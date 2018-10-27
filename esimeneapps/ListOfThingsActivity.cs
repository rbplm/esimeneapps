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
    [Activity(Label = "ListActivity")]
    public class ListOfThingsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ListLayout);



            // Create your application here

            var items = new string[] { "Tallinn", "Tartu", "Tapa" };


            var listView = FindViewById<ListView>(Resource.Id.listView1);
            listView.Adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);

        }
    }
}