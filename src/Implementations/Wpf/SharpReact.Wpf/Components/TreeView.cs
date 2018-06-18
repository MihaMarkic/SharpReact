using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TreeView<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.TreeView
		where TElement : global::System.Windows.Controls.TreeView, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.SelectedValuePath.HasValue)
			{
				Element.SelectedValuePath = nextProps.SelectedValuePath.Value.Value;
			}
			if (!ReferenceEquals(previous?.SelectedItemChanged, null) && ReferenceEquals(nextProps.SelectedItemChanged, null))
			{
				Element.SelectedItemChanged -= nextProps.SelectedItemChanged;
			}
			if (ReferenceEquals(previous?.SelectedItemChanged, null) && !ReferenceEquals(nextProps.SelectedItemChanged, null))
			{
				Element.SelectedItemChanged += nextProps.SelectedItemChanged;
			}
		}
	}
}
