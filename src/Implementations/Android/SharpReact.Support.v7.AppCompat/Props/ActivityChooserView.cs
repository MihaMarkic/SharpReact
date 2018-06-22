using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ActivityChooserView: ViewGroup
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ActivityChooserView<ActivityChooserView, global::Android.Support.V7.Widget.ActivityChooserView>();
		}
	}
}
