using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AdapterViewAnimator<TProps, TElement>: AdapterView<TProps, TElement>
		where TProps : Props.AdapterViewAnimator
		where TElement : global::Android.Widget.AdapterViewAnimator
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAdapterViewAnimatorWithInstanceProperties(Element, previous, nextProps);
			PostAssignAdapterViewAnimatorProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAdapterViewAnimatorProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAdapterViewAnimatorWithInstanceProperties(element, null, props);
		}
		static void UpdateAdapterViewAnimatorWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.DisplayedChild.HasValue)
			{
				element.DisplayedChild = nextProps.DisplayedChild.Value.Value;
			}
			if (nextProps.InAnimation.HasValue)
			{
				element.InAnimation = nextProps.InAnimation.Value.Value;
			}
			if (nextProps.OutAnimation.HasValue)
			{
				element.OutAnimation = nextProps.OutAnimation.Value.Value;
			}
		}
	}
}
