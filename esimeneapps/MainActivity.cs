using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace esimeneapps
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var count = 0;

            var firstButton = FindViewById<Button>(Resource.Id.button1);

            var firstTextView = FindViewById<TextView>(Resource.Id.editText1);
            var firstTextView1 = FindViewById<TextView>(Resource.Id.editText2);

            var firstButton2 = FindViewById<Button>(Resource.Id.button2);

            var firstTextView3 = FindViewById<TextView>(Resource.Id.textView1);

            firstButton.Click += delegate
            {
                count++;
                firstTextView.Text = count.ToString();
            };

            firstButton2.Click += delegate
            {
                var num1 = int.Parse(firstTextView.Text);
                var num2 = int.Parse(firstTextView1.Text);
                var answer = num1 + num2;
                firstTextView3.Text = answer.ToString();
            };
        }
    }
}