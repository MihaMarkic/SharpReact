using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class AdapterViewAnimator: AdapterView
	{
		public ReactParam<global::Android.Widget.IAdapter>? Adapter { get; set; }
		public ReactParam<global::System.Int32>? DisplayedChild { get; set; }
		public ReactParam<global::Android.Animation.ObjectAnimator>? InAnimation { get; set; }
		public ReactParam<global::Android.Animation.ObjectAnimator>? OutAnimation { get; set; }
	}
}
