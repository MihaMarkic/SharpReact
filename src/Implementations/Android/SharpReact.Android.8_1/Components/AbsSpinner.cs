using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AbsSpinner<TProps, TElement>: AdapterView<global::Android.Widget.ISpinnerAdapter, TProps, TElement>
		where TProps : Props.AbsSpinner
		where TElement : global::Android.Widget.AbsSpinner
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAbsSpinnerWithInstanceProperties(Element, previous, nextProps);
			PostAssignAbsSpinnerProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAbsSpinnerProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAbsSpinnerWithInstanceProperties(element, null, props);
		}
		static void UpdateAbsSpinnerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
		}
	}
}
