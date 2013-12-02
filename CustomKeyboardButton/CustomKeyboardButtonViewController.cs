using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace CustomKeyboardButton
{
	public partial class CustomKeyboardButtonViewController : UIViewController
	{
		public CustomKeyboardButtonViewController () : base ("CustomKeyboardButtonViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();

			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			MyUIToolbar toolbar = new MyUIToolbar (new RectangleF(0.0f, 0.0f, this.View.Frame.Size.Width, 44.0f));

			toolbar.TintColor = UIColor.White;
			toolbar.BarStyle = UIBarStyle.Black;

			toolbar.Translucent = true;

			var myButton = new UIBarButtonItem (":-)", 
				UIBarButtonItemStyle.Bordered, AddBarButtonText);


			toolbar.Items = new UIBarButtonItem[]{ 
				myButton,
				new UIBarButtonItem(":-)", 
					UIBarButtonItemStyle.Plain, AddBarButtonText),
				new UIBarButtonItem(":-(", 
					UIBarButtonItemStyle.Plain, AddBarButtonText),
				new UIBarButtonItem(";-)", 
					UIBarButtonItemStyle.Plain, AddBarButtonText),
				new UIBarButtonItem(":-P", 
					UIBarButtonItemStyle.Plain, AddBarButtonText),
				new UIBarButtonItem(UIBarButtonSystemItem.FlexibleSpace),
				new UIBarButtonItem(UIBarButtonSystemItem.Done, delegate {
					this.SampleText.ResignFirstResponder();
				})
			};

			this.SampleText.KeyboardAppearance = UIKeyboardAppearance.Dark;

			//TODO: uncomment this if you're replacing the entire keyboard
			//this.SampleText.InputView = toolbar;
			this.SampleText.InputAccessoryView = toolbar;
		}



		public void AddBarButtonText(object sender, EventArgs e)
		{
			var barButtonItem = sender as UIBarButtonItem;
			if (barButtonItem != null) {
				this.SampleText.Text += barButtonItem.Title;
				UIDevice.CurrentDevice.PlayInputClick ();
			}

		}
	}

	/// <summary>
	/// Toolbar that plays input clicks
	/// </summary>
	public class MyUIToolbar : UIToolbar
	{
		public MyUIToolbar (RectangleF rect) : base(rect)
		{

		}

		public override bool EnableInputClicksWhenVisible {
			get {
				return true;
			}
		}
	}



}

