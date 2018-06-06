using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ToggleButton<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.ToggleButton
		where TElement : System.Windows.Controls.Primitives.ToggleButton, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsChecked.HasValue)
			{
				Element.IsChecked = nextProps.IsChecked.Value.Value;
			}
			if (nextProps.IsThreeState.HasValue)
			{
				Element.IsThreeState = nextProps.IsThreeState.Value.Value;
			}
			if (!ReferenceEquals(Props?.Checked, null) && ReferenceEquals(nextProps.Checked, null))
			{
				Element.Checked -= nextProps.Checked;
			}
			if (ReferenceEquals(Props?.Checked, null) && !ReferenceEquals(nextProps.Checked, null))
			{
				Element.Checked += nextProps.Checked;
			}
			if (!ReferenceEquals(Props?.Unchecked, null) && ReferenceEquals(nextProps.Unchecked, null))
			{
				Element.Unchecked -= nextProps.Unchecked;
			}
			if (ReferenceEquals(Props?.Unchecked, null) && !ReferenceEquals(nextProps.Unchecked, null))
			{
				Element.Unchecked += nextProps.Unchecked;
			}
			if (!ReferenceEquals(Props?.Indeterminate, null) && ReferenceEquals(nextProps.Indeterminate, null))
			{
				Element.Indeterminate -= nextProps.Indeterminate;
			}
			if (ReferenceEquals(Props?.Indeterminate, null) && !ReferenceEquals(nextProps.Indeterminate, null))
			{
				Element.Indeterminate += nextProps.Indeterminate;
			}
		}
	}
}
