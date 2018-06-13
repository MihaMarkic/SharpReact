using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class Button: TextView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.Button<Button, global::Android.Widget.Button>();
		}
	}
}
