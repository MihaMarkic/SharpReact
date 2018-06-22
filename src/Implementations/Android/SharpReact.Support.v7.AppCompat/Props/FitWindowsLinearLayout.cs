using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class FitWindowsLinearLayout: LinearLayout
	{
		public System.EventHandler<global::Android.Support.V7.Widget.FitWindowsViewGroupOnFitSystemWindowsEventArgs> FitSystemWindows { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FitWindowsLinearLayout<FitWindowsLinearLayout, global::Android.Support.V7.Widget.FitWindowsLinearLayout>();
		}
	}
}
