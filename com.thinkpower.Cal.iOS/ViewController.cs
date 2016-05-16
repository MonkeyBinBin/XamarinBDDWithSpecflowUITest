using System;

using UIKit;

namespace com.thinkpower.Cal.iOS
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

			//editTextNumber.ShouldChangeCharacters += (field, range, replacementString) => false;

			buttonClear.TouchUpInside += delegate {
				_totalValue = 0;
				_isInputNumber = false;
				editTextNumber.Text = _totalValue.ToString ();
			};

			buttonAdd.TouchUpInside += delegate {
				Cal();
			};

			buttonEqual.TouchUpInside += delegate {
				Cal();
			};

			this.button0.TouchUpInside += NumberClick;
			this.button1.TouchUpInside += NumberClick;
			this.button2.TouchUpInside += NumberClick;
			this.button3.TouchUpInside += NumberClick;
			this.button4.TouchUpInside += NumberClick;
			this.button5.TouchUpInside += NumberClick;
			this.button6.TouchUpInside += NumberClick;
			this.button7.TouchUpInside += NumberClick;
			this.button8.TouchUpInside += NumberClick;
			this.button9.TouchUpInside += NumberClick;
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		private void NumberClick(object sender, System.EventArgs e) {
			var temp = (UIButton)sender;
			if (_isInputNumber) 
				editTextNumber.Text += temp.Title(UIControlState.Normal);
			else
				editTextNumber.Text = temp.Title(UIControlState.Normal);

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
	}
}

