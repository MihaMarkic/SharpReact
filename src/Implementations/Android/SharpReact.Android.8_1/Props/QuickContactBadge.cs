using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class QuickContactBadge: ImageView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.QuickContactBadge<QuickContactBadge, global::Android.Widget.QuickContactBadge>();
		}
	}
}
