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

namespace App1
{
    [Activity(Label = "FourthActivity")]
    public class FourthActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.fourth_layout);
            var textview1 = FindViewById<TextView>(Resource.Id.textView1);

            var myText = Intent.GetStringExtra("MyData");
            textview1.Text = myText;
        }
    }
}