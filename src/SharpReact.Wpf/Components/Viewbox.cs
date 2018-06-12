using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Viewbox<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.Viewbox
		where TElement : global::System.Windows.Controls.Viewbox, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
			if (nextProps.Stretch.HasValue)
			{
				Element.Stretch = nextProps.Stretch.Value.Value;
			}
			if (nextProps.StretchDirection.HasValue)
			{
				Element.StretchDirection = nextProps.StretchDirection.Value.Value;
			}
		}
	}
}
