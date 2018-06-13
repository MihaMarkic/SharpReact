using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class GridLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.GridLayout
		where TElement : global::Android.Widget.GridLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.GridLayout(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.AlignmentMode.HasValue)
			{
				Element.AlignmentMode = nextProps.AlignmentMode.Value.Value;
			}
			if (nextProps.ColumnCount.HasValue)
			{
				Element.ColumnCount = nextProps.ColumnCount.Value.Value;
			}
			if (nextProps.ColumnOrderPreserved.HasValue)
			{
				Element.ColumnOrderPreserved = nextProps.ColumnOrderPreserved.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.RowCount.HasValue)
			{
				Element.RowCount = nextProps.RowCount.Value.Value;
			}
			if (nextProps.RowOrderPreserved.HasValue)
			{
				Element.RowOrderPreserved = nextProps.RowOrderPreserved.Value.Value;
			}
			if (nextProps.UseDefaultMargins.HasValue)
			{
				Element.UseDefaultMargins = nextProps.UseDefaultMargins.Value.Value;
			}
		}
	}
}
