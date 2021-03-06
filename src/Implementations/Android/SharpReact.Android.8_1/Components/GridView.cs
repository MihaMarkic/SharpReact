using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class GridView<TProps, TElement>: AbsListView<TProps, TElement>
		where TProps : Props.GridView
		where TElement : global::Android.Widget.GridView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.GridView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateGridViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignGridViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignGridViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateGridViewWithInstanceProperties(element, null, props);
		}
		static void UpdateGridViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.NumColumns.HasValue)
			{
				element.NumColumns = nextProps.NumColumns.Value.Value;
			}
			if (nextProps.StretchMode.HasValue)
			{
				element.StretchMode = nextProps.StretchMode.Value.Value;
			}
		}
	}
}
