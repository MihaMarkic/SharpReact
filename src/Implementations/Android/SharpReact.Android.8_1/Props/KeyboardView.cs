using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class KeyboardView: View
	{
		public ReactParam<global::Android.InputMethodServices.Keyboard>? Keyboard { get; set; }
		public ReactParam<global::Android.InputMethodServices.KeyboardView.IOnKeyboardActionListener>? OnKeyboardActionListener { get; set; }
		public ReactParam<global::System.Boolean>? PreviewEnabled { get; set; }
		public ReactParam<global::System.Boolean>? ProximityCorrectionEnabled { get; set; }
		public System.EventHandler<global::Android.InputMethodServices.KeyboardView.KeyEventArgs> Key { get; set; }
		public System.EventHandler<global::Android.InputMethodServices.KeyboardView.PressEventArgs> Press { get; set; }
		public System.EventHandler<global::Android.InputMethodServices.KeyboardView.ReleaseEventArgs> Release { get; set; }
		public System.EventHandler<global::Android.InputMethodServices.KeyboardView.TextEventArgs> Text { get; set; }
		public System.EventHandler SwipeDownEvent { get; set; }
		public System.EventHandler SwipeLeftEvent { get; set; }
		public System.EventHandler SwipeRightEvent { get; set; }
		public System.EventHandler SwipeUpEvent { get; set; }
	}
}
