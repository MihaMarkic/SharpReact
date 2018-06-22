using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class FitWindowsFrameLayout: FrameLayout
	{
		public System.EventHandler<global::Android.Support.V7.Widget.FitWindowsViewGroupOnFitSystemWindowsEventArgs> FitSystemWindows { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FitWindowsFrameLayout<FitWindowsFrameLayout, global::Android.Support.V7.Widget.FitWindowsFrameLayout>();
		}
	}
}
