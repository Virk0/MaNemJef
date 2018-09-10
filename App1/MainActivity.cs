using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            int count = 0;
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var button = FindViewById<Button>(Resource.Id.button1);
            var buttonSecondActivity = FindViewById<Button>(Resource.Id.button2);
            var buttonThirdActivity = FindViewById<Button>(Resource.Id.button3);
            var buttonFourthActivity = FindViewById<Button>(Resource.Id.button4);

            button.Click += delegate
            {
                count++;
                textView.Text = "OMEGALUL'd " + count + " times";
            };

            buttonSecondActivity.Click += ButtonSecondActivity_Click;
            buttonThirdActivity.Click += ButtonThirdActivity_Click;
            buttonFourthActivity.Click += ButtonFourthActivity_Click;
        }

        private void ButtonFourthActivity_Click(object sender, System.EventArgs e)
        {
            var fourthActivity = new Intent(this, typeof(FourthActivity));
            var MainText = FindViewById<EditText>(Resource.Id.editText1);

            fourthActivity.PutExtra("MyData", MainText.Text);
            StartActivity(fourthActivity);
        }

        private void ButtonThirdActivity_Click(object sender, System.EventArgs e)
        {
            var thirdActivity = new Intent(this, typeof(ThirdActivity));
            StartActivity(thirdActivity);
        }

        private void ButtonSecondActivity_Click(object sender, System.EventArgs e)
        {
            var secondActivity = new Intent(this, typeof(SecondActivity));
            StartActivity(secondActivity);
        }

    }
}