
namespace SharpReact.Wpf.Components
{
	public  class ComboBox<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.ComboBox
		where TElement : System.Windows.Controls.ComboBox
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ComboBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.MaxDropDownHeight.HasValue)
			{
				Element.MaxDropDownHeight = nextProps.MaxDropDownHeight.Value.Value;
			}
			if (nextProps.IsDropDownOpen.HasValue)
			{
				Element.IsDropDownOpen = nextProps.IsDropDownOpen.Value.Value;
			}
			if (nextProps.ShouldPreserveUserEnteredPrefix.HasValue)
			{
				Element.ShouldPreserveUserEnteredPrefix = nextProps.ShouldPreserveUserEnteredPrefix.Value.Value;
			}
			if (nextProps.IsEditable.HasValue)
			{
				Element.IsEditable = nextProps.IsEditable.Value.Value;
			}
			if (nextProps.Text.HasValue)
			{
				Element.Text = nextProps.Text.Value.Value;
			}
			if (nextProps.IsReadOnly.HasValue)
			{
				Element.IsReadOnly = nextProps.IsReadOnly.Value.Value;
			}
			if (nextProps.StaysOpenOnEdit.HasValue)
			{
				Element.StaysOpenOnEdit = nextProps.StaysOpenOnEdit.Value.Value;
			}
			if (!ReferenceEquals(Props?.DropDownOpened, null) && ReferenceEquals(nextProps.DropDownOpened, null))
			{
				Element.DropDownOpened -= nextProps.DropDownOpened;
			}
			if (ReferenceEquals(Props?.DropDownOpened, null) && !ReferenceEquals(nextProps.DropDownOpened, null))
			{
				Element.DropDownOpened += nextProps.DropDownOpened;
			}
			if (!ReferenceEquals(Props?.DropDownClosed, null) && ReferenceEquals(nextProps.DropDownClosed, null))
			{
				Element.DropDownClosed -= nextProps.DropDownClosed;
			}
			if (ReferenceEquals(Props?.DropDownClosed, null) && !ReferenceEquals(nextProps.DropDownClosed, null))
			{
				Element.DropDownClosed += nextProps.DropDownClosed;
			}
		}
	}
}
