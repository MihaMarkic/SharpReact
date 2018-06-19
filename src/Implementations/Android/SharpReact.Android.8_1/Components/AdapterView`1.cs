using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AdapterView<T, TProps, TElement>: AdapterView<TProps, TElement>
		where TProps : Props.AdapterView<T>
		where TElement : global::Android.Widget.AdapterView<T>
		where T: global::Android.Widget.IAdapter 
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAdapterViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignAdapterViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAdapterViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAdapterViewWithInstanceProperties(element, null, props);
		}
		static void UpdateAdapterViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
		}
	}
}
