using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Border<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.Border
		where TElement : global::System.Windows.Controls.Border, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.BorderThickness.HasValue)
			{
				Element.BorderThickness = nextProps.BorderThickness.Value.Value;
			}
			if (nextProps.Padding.HasValue)
			{
				Element.Padding = nextProps.Padding.Value.Value;
			}
			if (nextProps.CornerRadius.HasValue)
			{
				Element.CornerRadius = nextProps.CornerRadius.Value.Value;
			}
			if (nextProps.BorderBrush.HasValue)
			{
				Element.BorderBrush = nextProps.BorderBrush.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
		}
	}
}
