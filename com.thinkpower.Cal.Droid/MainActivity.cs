using Android.App;
using Android.Widget;
using Android.OS;

namespace com.thinkpower.Cal.Droid
{
	[Activity (Label = "Cal", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			buttonClear = FindViewById<Button> (Resource.Id.buttonClear);
			buttonAdd = FindViewById<Button> (Resource.Id.buttonAdd);
			buttonEqual = FindViewById<Button> (Resource.Id.buttonEqual);
			editTextNumber = FindViewById<EditText> (Resource.Id.editTextNumber);
			editTextNumber.Focusable = false;
			button0 = FindViewById<Button> (Resource.Id.button0);
			button1 = FindViewById<Button> (Resource.Id.button1);
			button2 = FindViewById<Button> (Resource.Id.button2);
			button3 = FindViewById<Button> (Resource.Id.button3);
			button4 = FindViewById<Button> (Resource.Id.button4);
			button5 = FindViewById<Button> (Resource.Id.button5);
			button6 = FindViewById<Button> (Resource.Id.button6);
			button7 = FindViewById<Button> (Resource.Id.button7);
			button8 = FindViewById<Button> (Resource.Id.button8);
			button9 = FindViewById<Button> (Resource.Id.button9);

			buttonClear.Click += delegate {
				_totalValue = 0;
				_isInputNumber = false;
				editTextNumber.Text = _totalValue.ToString ();
			};

			buttonAdd.Click += delegate {
				Cal();
			};

			buttonEqual.Click += delegate {
				Cal();
			};

			button0.Click += NumberClick;
			button1.Click += NumberClick;
			button2.Click += NumberClick;
			button3.Click += NumberClick;
			button4.Click += NumberClick;
			button5.Click += NumberClick;
			button6.Click += NumberClick;
			button7.Click += NumberClick;
			button8.Click += NumberClick;
			button9.Click += NumberClick;
		}

		private void NumberClick(object sender, System.EventArgs e) {
			var temp = (Button)sender;
			if (_isInputNumber) 
				editTextNumber.Text += temp.Text;
			else
				editTextNumber.Text = temp.Text;

			_isInputNumber = true;
		}

		private void Cal(){
			decimal value = 0;
			if (decimal.TryParse (editTextNumber.Text, out value) && _isInputNumber) {					
				_totalValue += value;
				_isInputNumber = false;
			}
			editTextNumber.Text = _totalValue.ToString();
		}

		private decimal _totalValue = 0;
		private bool _isInputNumber = false;

		private Button buttonClear;
		private Button buttonAdd;
		private Button buttonEqual;
		private EditText editTextNumber;

		private Button button0;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private Button button9;
	}
}


