using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class AdornerLayer<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.AdornerLayer
		where TElement : System.Windows.Documents.AdornerLayer, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
