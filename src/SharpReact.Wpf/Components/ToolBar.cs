using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ToolBar<TProps, TElement>: HeaderedItemsControl<TProps, TElement>
		where TProps : Props.ToolBar
		where TElement : System.Windows.Controls.ToolBar, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Band.HasValue)
			{
				Element.Band = nextProps.Band.Value.Value;
			}
			if (nextProps.BandIndex.HasValue)
			{
				Element.BandIndex = nextProps.BandIndex.Value.Value;
			}
			if (nextProps.IsOverflowOpen.HasValue)
			{
				Element.IsOverflowOpen = nextProps.IsOverflowOpen.Value.Value;
			}
		}
	}
}
