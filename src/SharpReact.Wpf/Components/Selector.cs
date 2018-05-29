
namespace SharpReact.Wpf.Components
{
	public abstract class Selector<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.Selector
		where TElement : System.Windows.Controls.Primitives.Selector
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsSynchronizedWithCurrentItem.HasValue)
			{
				Element.IsSynchronizedWithCurrentItem = nextProps.IsSynchronizedWithCurrentItem.Value.Value;
			}
			if (nextProps.SelectedIndex.HasValue)
			{
				Element.SelectedIndex = nextProps.SelectedIndex.Value.Value;
			}
			if (nextProps.SelectedItem.HasValue)
			{
				Element.SelectedItem = nextProps.SelectedItem.Value.Value;
			}
			if (nextProps.SelectedValue.HasValue)
			{
				Element.SelectedValue = nextProps.SelectedValue.Value.Value;
			}
			if (nextProps.SelectedValuePath.HasValue)
			{
				Element.SelectedValuePath = nextProps.SelectedValuePath.Value.Value;
			}
			if (!ReferenceEquals(Props?.SelectionChanged, null) && ReferenceEquals(nextProps.SelectionChanged, null))
			{
				Element.SelectionChanged -= nextProps.SelectionChanged;
			}
			if (ReferenceEquals(Props?.SelectionChanged, null) && !ReferenceEquals(nextProps.SelectionChanged, null))
			{
				Element.SelectionChanged += nextProps.SelectionChanged;
			}
		}
	}
}
