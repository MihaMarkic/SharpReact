using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class PasswordBox<TProps>: Control<TProps, global::System.Windows.Controls.PasswordBox>
		where TProps : Props.PasswordBox
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
			if (!ReferenceEquals(previous?.PasswordChanged, null) && ReferenceEquals(nextProps.PasswordChanged, null))
			{
				Element.PasswordChanged -= nextProps.PasswordChanged;
			}
			if (ReferenceEquals(previous?.PasswordChanged, null) && !ReferenceEquals(nextProps.PasswordChanged, null))
			{
				Element.PasswordChanged += nextProps.PasswordChanged;
			}
		}
	}
}
