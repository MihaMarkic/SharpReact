using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Expander<TProps, TElement>: HeaderedContentControl<TProps, TElement>
		where TProps : Props.Expander
		where TElement : System.Windows.Controls.Expander, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ExpandDirection.HasValue)
			{
				Element.ExpandDirection = nextProps.ExpandDirection.Value.Value;
			}
			if (nextProps.IsExpanded.HasValue)
			{
				Element.IsExpanded = nextProps.IsExpanded.Value.Value;
			}
			if (!ReferenceEquals(previous?.Expanded, null) && ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded -= nextProps.Expanded;
			}
			if (ReferenceEquals(previous?.Expanded, null) && !ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded += nextProps.Expanded;
			}
			if (!ReferenceEquals(previous?.Collapsed, null) && ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed -= nextProps.Collapsed;
			}
			if (ReferenceEquals(previous?.Collapsed, null) && !ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed += nextProps.Collapsed;
			}
		}
	}
}
