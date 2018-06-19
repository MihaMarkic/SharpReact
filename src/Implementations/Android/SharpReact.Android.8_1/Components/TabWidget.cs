using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TabWidget<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TabWidget
		where TElement : global::Android.Widget.TabWidget
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TabWidget(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateTabWidgetWithInstanceProperties(Element, previous, nextProps);
			PostAssignTabWidgetProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignTabWidgetProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTabWidgetWithInstanceProperties(element, null, props);
		}
		static void UpdateTabWidgetWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.StripEnabled.HasValue)
			{
				element.StripEnabled = nextProps.StripEnabled.Value.Value;
			}
		}
	}
}
