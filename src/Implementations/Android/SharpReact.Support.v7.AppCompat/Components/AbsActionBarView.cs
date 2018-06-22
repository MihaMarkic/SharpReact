using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public abstract partial class AbsActionBarView<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AbsActionBarView
		where TElement : global::Android.Support.V7.Widget.AbsActionBarView
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAbsActionBarViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignAbsActionBarViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAbsActionBarViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAbsActionBarViewWithInstanceProperties(element, null, props);
		}
		static void UpdateAbsActionBarViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.ContentHeight.HasValue)
			{
				element.ContentHeight = nextProps.ContentHeight.Value.Value;
			}
		}
	}
}
