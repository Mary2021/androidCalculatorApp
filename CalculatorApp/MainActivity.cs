using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace CalculatorApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView answerTextView;
        EditText firstNumberEditText;
        EditText secondNumberEditText;
        Button addButton;
        Button subtractButton;
        Button multiplyButton;
        Button divideButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            firstNumberEditText = FindViewById<EditText>(Resource.Id.editText1);
            secondNumberEditText = FindViewById<EditText>(Resource.Id.editText2);
            addButton = FindViewById<Button>(Resource.Id.addButton);
            subtractButton = FindViewById<Button>(Resource.Id.subtractButton);
            multiplyButton = FindViewById<Button>(Resource.Id.multiplyButton);
            divideButton = FindViewById<Button>(Resource.Id.divideButton);
            answerTextView = FindViewById<TextView>(Resource.Id.answerTextView);
            addButton.Click += addButton_Click;
            multiplyButton.Click += multiplyButton_Click;
            subtractButton.Click += subtractButton_Click;
            divideButton.Click += divideButton_Click;
            addButton.Click += addButton_Click;

        }
        private void addButton_Click(object Sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber + secondNumber;

            answerTextView.Text = answer.ToString();
        }

        private void subtractButton_Click(object Sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber - secondNumber;

            answerTextView.Text = answer.ToString();
        }

        private void multiplyButton_Click(object Sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber * secondNumber;

            answerTextView.Text = answer.ToString();
        }

        private void divideButton_Click(object Sender, System.EventArgs e)
        {
            var firstNumber = double.Parse(firstNumberEditText.Text);
            var secondNumber = double.Parse(secondNumberEditText.Text);
            var answer = firstNumber / secondNumber;

            answerTextView.Text = answer.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}