using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class EditText: TextView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.EditText<EditText, global::Android.Widget.EditText>();
		}
	}
}
