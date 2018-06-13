using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class PageFunctionBase<TProps, TElement>: Page<TProps, TElement>
		where TProps : Props.PageFunctionBase
		where TElement : global::System.Windows.Navigation.PageFunctionBase, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.RemoveFromJournal.HasValue)
			{
				Element.RemoveFromJournal = nextProps.RemoveFromJournal.Value.Value;
			}
		}
	}
}
