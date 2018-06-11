using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class MenuItem<TProps, TElement>: HeaderedItemsControl<TProps, TElement>
		where TProps : Props.MenuItem
		where TElement : System.Windows.Controls.MenuItem, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Command.HasValue)
			{
				Element.Command = nextProps.Command.Value.Value;
			}
			if (nextProps.CommandParameter.HasValue)
			{
				Element.CommandParameter = nextProps.CommandParameter.Value.Value;
			}
			if (nextProps.CommandTarget.HasValue)
			{
				Element.CommandTarget = nextProps.CommandTarget.Value.Value;
			}
			if (nextProps.IsSubmenuOpen.HasValue)
			{
				Element.IsSubmenuOpen = nextProps.IsSubmenuOpen.Value.Value;
			}
			if (nextProps.IsCheckable.HasValue)
			{
				Element.IsCheckable = nextProps.IsCheckable.Value.Value;
			}
			if (nextProps.IsChecked.HasValue)
			{
				Element.IsChecked = nextProps.IsChecked.Value.Value;
			}
			if (nextProps.StaysOpenOnClick.HasValue)
			{
				Element.StaysOpenOnClick = nextProps.StaysOpenOnClick.Value.Value;
			}
			if (nextProps.InputGestureText.HasValue)
			{
				Element.InputGestureText = nextProps.InputGestureText.Value.Value;
			}
			if (nextProps.Icon.HasValue)
			{
				Element.Icon = nextProps.Icon.Value.Value;
			}
			if (nextProps.ItemContainerTemplateSelector.HasValue)
			{
				Element.ItemContainerTemplateSelector = nextProps.ItemContainerTemplateSelector.Value.Value;
			}
			if (nextProps.UsesItemContainerTemplate.HasValue)
			{
				Element.UsesItemContainerTemplate = nextProps.UsesItemContainerTemplate.Value.Value;
			}
			if (!ReferenceEquals(previous?.Click, null) && ReferenceEquals(nextProps.Click, null))
			{
				Element.Click -= nextProps.Click;
			}
			if (ReferenceEquals(previous?.Click, null) && !ReferenceEquals(nextProps.Click, null))
			{
				Element.Click += nextProps.Click;
			}
			if (!ReferenceEquals(previous?.Checked, null) && ReferenceEquals(nextProps.Checked, null))
			{
				Element.Checked -= nextProps.Checked;
			}
			if (ReferenceEquals(previous?.Checked, null) && !ReferenceEquals(nextProps.Checked, null))
			{
				Element.Checked += nextProps.Checked;
			}
			if (!ReferenceEquals(previous?.Unchecked, null) && ReferenceEquals(nextProps.Unchecked, null))
			{
				Element.Unchecked -= nextProps.Unchecked;
			}
			if (ReferenceEquals(previous?.Unchecked, null) && !ReferenceEquals(nextProps.Unchecked, null))
			{
				Element.Unchecked += nextProps.Unchecked;
			}
			if (!ReferenceEquals(previous?.SubmenuOpened, null) && ReferenceEquals(nextProps.SubmenuOpened, null))
			{
				Element.SubmenuOpened -= nextProps.SubmenuOpened;
			}
			if (ReferenceEquals(previous?.SubmenuOpened, null) && !ReferenceEquals(nextProps.SubmenuOpened, null))
			{
				Element.SubmenuOpened += nextProps.SubmenuOpened;
			}
			if (!ReferenceEquals(previous?.SubmenuClosed, null) && ReferenceEquals(nextProps.SubmenuClosed, null))
			{
				Element.SubmenuClosed -= nextProps.SubmenuClosed;
			}
			if (ReferenceEquals(previous?.SubmenuClosed, null) && !ReferenceEquals(nextProps.SubmenuClosed, null))
			{
				Element.SubmenuClosed += nextProps.SubmenuClosed;
			}
		}
	}
}
