using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ListView<TProps, TElement>: AbsListView<TProps, TElement>
		where TProps : Props.ListView
		where TElement : global::Android.Widget.ListView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.ChoiceMode.HasValue)
			{
				Element.ChoiceMode = nextProps.ChoiceMode.Value.Value;
			}
			if (nextProps.Divider.HasValue)
			{
				Element.Divider = nextProps.Divider.Value.Value;
			}
			if (nextProps.DividerHeight.HasValue)
			{
				Element.DividerHeight = nextProps.DividerHeight.Value.Value;
			}
			if (nextProps.ItemsCanFocus.HasValue)
			{
				Element.ItemsCanFocus = nextProps.ItemsCanFocus.Value.Value;
			}
			if (nextProps.OverscrollFooter.HasValue)
			{
				Element.OverscrollFooter = nextProps.OverscrollFooter.Value.Value;
			}
			if (nextProps.OverscrollHeader.HasValue)
			{
				Element.OverscrollHeader = nextProps.OverscrollHeader.Value.Value;
			}
		}
	}
}
