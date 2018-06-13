using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class StackView: AdapterViewAnimator
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.StackView<StackView, global::Android.Widget.StackView>();
		}
	}
}
