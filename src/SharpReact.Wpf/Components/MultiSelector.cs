using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class MultiSelector<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.MultiSelector
		where TElement : global::System.Windows.Controls.Primitives.MultiSelector, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
