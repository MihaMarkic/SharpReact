
namespace SharpReact.Wpf.Components
{
	public  class ToggleButton<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.ToggleButton
		where TElement : System.Windows.Controls.Primitives.ToggleButton
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.ToggleButton();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
