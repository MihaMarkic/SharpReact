using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class DialogTitle: TextView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DialogTitle<DialogTitle, global::Android.Support.V7.Widget.DialogTitle>();
		}
	}
}
