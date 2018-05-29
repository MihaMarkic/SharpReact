
namespace SharpReact.Wpf.Components
{
	public  class PasswordBox<TProps>: Control<TProps, System.Windows.Controls.PasswordBox>
		where TProps : Props.PasswordBox
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Controls.PasswordBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Password.HasValue)
			{
				Element.Password = nextProps.Password.Value.Value;
			}
			if (nextProps.PasswordChar.HasValue)
			{
				Element.PasswordChar = nextProps.PasswordChar.Value.Value;
			}
			if (nextProps.MaxLength.HasValue)
			{
				Element.MaxLength = nextProps.MaxLength.Value.Value;
			}
			if (nextProps.SelectionBrush.HasValue)
			{
				Element.SelectionBrush = nextProps.SelectionBrush.Value.Value;
			}
			if (nextProps.SelectionOpacity.HasValue)
			{
				Element.SelectionOpacity = nextProps.SelectionOpacity.Value.Value;
			}
			if (nextProps.CaretBrush.HasValue)
			{
				Element.CaretBrush = nextProps.CaretBrush.Value.Value;
			}
			if (nextProps.IsInactiveSelectionHighlightEnabled.HasValue)
			{
				Element.IsInactiveSelectionHighlightEnabled = nextProps.IsInactiveSelectionHighlightEnabled.Value.Value;
			}
			if (!ReferenceEquals(Props?.PasswordChanged, null) && ReferenceEquals(nextProps.PasswordChanged, null))
			{
				Element.PasswordChanged -= nextProps.PasswordChanged;
			}
			if (ReferenceEquals(Props?.PasswordChanged, null) && !ReferenceEquals(nextProps.PasswordChanged, null))
			{
				Element.PasswordChanged += nextProps.PasswordChanged;
			}
		}
	}
}
