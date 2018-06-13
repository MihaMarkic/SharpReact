using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class Adorner<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Adorner
		where TElement : global::System.Windows.Documents.Adorner, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsClipEnabled.HasValue)
			{
				Element.IsClipEnabled = nextProps.IsClipEnabled.Value.Value;
			}
		}
	}
}
