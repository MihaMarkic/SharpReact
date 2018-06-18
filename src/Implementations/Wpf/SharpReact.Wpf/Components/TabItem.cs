using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TabItem<TProps, TElement>: HeaderedContentControl<TProps, TElement>
		where TProps : Props.TabItem
		where TElement : global::System.Windows.Controls.TabItem, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsSelected.HasValue)
			{
				Element.IsSelected = nextProps.IsSelected.Value.Value;
			}
		}
	}
}
