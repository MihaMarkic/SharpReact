using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AbsSpinner<TProps, TElement>: AdapterView<global::Android.Widget.ISpinnerAdapter, TProps, TElement>
		where TProps : Props.AbsSpinner
		where TElement : global::Android.Widget.AbsSpinner
	{
		partial void PostAssignAbsSpinnerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
