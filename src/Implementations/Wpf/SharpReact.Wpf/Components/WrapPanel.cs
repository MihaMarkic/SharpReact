using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class WrapPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.WrapPanel
		where TElement : global::System.Windows.Controls.WrapPanel, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ItemWidth.HasValue)
			{
				Element.ItemWidth = nextProps.ItemWidth.Value.Value;
			}
			if (nextProps.ItemHeight.HasValue)
			{
				Element.ItemHeight = nextProps.ItemHeight.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
		}
	}
}
