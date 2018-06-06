using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class AdornedElementPlaceholder<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.AdornedElementPlaceholder
		where TElement : System.Windows.Controls.AdornedElementPlaceholder, new()
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
