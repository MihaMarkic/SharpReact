using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class GridLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.GridLayout
		where TElement : global::Android.Widget.GridLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.GridLayout(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateGridLayoutWithInstanceProperties(Element, previous, nextProps);
			PostAssignGridLayoutProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignGridLayoutProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateGridLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateGridLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.AlignmentMode.HasValue)
			{
				element.AlignmentMode = nextProps.AlignmentMode.Value.Value;
			}
			if (nextProps.ColumnCount.HasValue)
			{
				element.ColumnCount = nextProps.ColumnCount.Value.Value;
			}
			if (nextProps.ColumnOrderPreserved.HasValue)
			{
				element.ColumnOrderPreserved = nextProps.ColumnOrderPreserved.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.RowCount.HasValue)
			{
				element.RowCount = nextProps.RowCount.Value.Value;
			}
			if (nextProps.RowOrderPreserved.HasValue)
			{
				element.RowOrderPreserved = nextProps.RowOrderPreserved.Value.Value;
			}
			if (nextProps.UseDefaultMargins.HasValue)
			{
				element.UseDefaultMargins = nextProps.UseDefaultMargins.Value.Value;
			}
		}
	}
}
