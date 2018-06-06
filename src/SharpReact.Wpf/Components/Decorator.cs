using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Decorator<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Decorator
		where TElement : System.Windows.Controls.Decorator, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
		}
	}
}
