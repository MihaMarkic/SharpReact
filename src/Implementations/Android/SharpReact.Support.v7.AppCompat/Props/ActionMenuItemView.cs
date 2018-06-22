using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ActionMenuItemView: AppCompatTextView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ActionMenuItemView<ActionMenuItemView, global::Android.Support.V7.View.Menu.ActionMenuItemView>();
		}
	}
}
