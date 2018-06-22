using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class AlertDialogLayout: LinearLayoutCompat
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AlertDialogLayout<AlertDialogLayout, global::Android.Support.V7.Widget.AlertDialogLayout>();
		}
	}
}
