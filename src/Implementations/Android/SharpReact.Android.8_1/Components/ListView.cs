using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class ListView<TProps, TElement>: AbsListView<TProps, TElement>
		where TProps : Props.ListView
		where TElement : global::Android.Widget.ListView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ListView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateListViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignListViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignListViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateListViewWithInstanceProperties(element, null, props);
		}
		static void UpdateListViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.ChoiceMode.HasValue)
			{
				element.ChoiceMode = nextProps.ChoiceMode.Value.Value;
			}
			if (nextProps.Divider.HasValue)
			{
				element.Divider = nextProps.Divider.Value.Value;
			}
			if (nextProps.DividerHeight.HasValue)
			{
				element.DividerHeight = nextProps.DividerHeight.Value.Value;
			}
			if (nextProps.ItemsCanFocus.HasValue)
			{
				element.ItemsCanFocus = nextProps.ItemsCanFocus.Value.Value;
			}
			if (nextProps.OverscrollFooter.HasValue)
			{
				element.OverscrollFooter = nextProps.OverscrollFooter.Value.Value;
			}
			if (nextProps.OverscrollHeader.HasValue)
			{
				element.OverscrollHeader = nextProps.OverscrollHeader.Value.Value;
			}
		}
	}
}
