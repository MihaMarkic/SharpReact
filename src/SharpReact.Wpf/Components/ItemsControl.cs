using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ItemsControl<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.ItemsControl
		where TElement : System.Windows.Controls.ItemsControl, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.ItemsSource.HasValue)
			{
				Element.ItemsSource = nextProps.ItemsSource.Value.Value;
			}
			if (nextProps.DisplayMemberPath.HasValue)
			{
				Element.DisplayMemberPath = nextProps.DisplayMemberPath.Value.Value;
			}
			if (nextProps.ItemTemplate.HasValue)
			{
				Element.ItemTemplate = nextProps.ItemTemplate.Value.Value;
			}
			if (nextProps.ItemTemplateSelector.HasValue)
			{
				Element.ItemTemplateSelector = nextProps.ItemTemplateSelector.Value.Value;
			}
			if (nextProps.ItemStringFormat.HasValue)
			{
				Element.ItemStringFormat = nextProps.ItemStringFormat.Value.Value;
			}
			if (nextProps.ItemBindingGroup.HasValue)
			{
				Element.ItemBindingGroup = nextProps.ItemBindingGroup.Value.Value;
			}
			if (nextProps.ItemContainerStyle.HasValue)
			{
				Element.ItemContainerStyle = nextProps.ItemContainerStyle.Value.Value;
			}
			if (nextProps.ItemContainerStyleSelector.HasValue)
			{
				Element.ItemContainerStyleSelector = nextProps.ItemContainerStyleSelector.Value.Value;
			}
			if (nextProps.ItemsPanel.HasValue)
			{
				Element.ItemsPanel = nextProps.ItemsPanel.Value.Value;
			}
			if (nextProps.GroupStyleSelector.HasValue)
			{
				Element.GroupStyleSelector = nextProps.GroupStyleSelector.Value.Value;
			}
			if (nextProps.AlternationCount.HasValue)
			{
				Element.AlternationCount = nextProps.AlternationCount.Value.Value;
			}
			if (nextProps.IsTextSearchEnabled.HasValue)
			{
				Element.IsTextSearchEnabled = nextProps.IsTextSearchEnabled.Value.Value;
			}
			if (nextProps.IsTextSearchCaseSensitive.HasValue)
			{
				Element.IsTextSearchCaseSensitive = nextProps.IsTextSearchCaseSensitive.Value.Value;
			}
		}
	}
}
