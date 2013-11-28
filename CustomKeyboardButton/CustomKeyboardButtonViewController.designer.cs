// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace CustomKeyboardButton
{
	[Register ("CustomKeyboardButtonViewController")]
	partial class CustomKeyboardButtonViewController
	{
		[Outlet]
		public MonoTouch.UIKit.UITextField SampleText { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SampleText != null) {
				SampleText.Dispose ();
				SampleText = null;
			}
		}
	}
}
