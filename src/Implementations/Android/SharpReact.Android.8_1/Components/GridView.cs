using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class GridView<TProps, TElement>: AbsListView<TProps, TElement>
		where TProps : Props.GridView
		where TElement : global::Android.Widget.GridView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.NumColumns.HasValue)
			{
				Element.NumColumns = nextProps.NumColumns.Value.Value;
			}
			if (nextProps.StretchMode.HasValue)
			{
				Element.StretchMode = nextProps.StretchMode.Value.Value;
			}
		}
	}
}