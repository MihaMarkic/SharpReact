using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ExtractEditText: EditText
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ExtractEditText<ExtractEditText, global::Android.InputMethodServices.ExtractEditText>();
		}
	}
}
