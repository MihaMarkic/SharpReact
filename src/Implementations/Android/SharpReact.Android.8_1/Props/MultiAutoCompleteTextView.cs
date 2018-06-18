using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class MultiAutoCompleteTextView: AutoCompleteTextView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.MultiAutoCompleteTextView<MultiAutoCompleteTextView, global::Android.Widget.MultiAutoCompleteTextView>();
		}
	}
}
