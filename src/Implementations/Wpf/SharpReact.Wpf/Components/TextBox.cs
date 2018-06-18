using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class TextBox<TProps, TElement>: TextBoxBase<TProps, TElement>
		where TProps : Props.TextBox
		where TElement : global::System.Windows.Controls.TextBox, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.TextWrapping.HasValue)
			{
				Element.TextWrapping = nextProps.TextWrapping.Value.Value;
			}
			if (nextProps.MinLines.HasValue)
			{
				Element.MinLines = nextProps.MinLines.Value.Value;
			}
			if (nextProps.MaxLines.HasValue)
			{
				Element.MaxLines = nextProps.MaxLines.Value.Value;
			}
			if (nextProps.Text.HasValue)
			{
				Element.Text = nextProps.Text.Value.Value;
			}
			if (nextProps.CharacterCasing.HasValue)
			{
				Element.CharacterCasing = nextProps.CharacterCasing.Value.Value;
			}
			if (nextProps.MaxLength.HasValue)
			{
				Element.MaxLength = nextProps.MaxLength.Value.Value;
			}
			if (nextProps.TextAlignment.HasValue)
			{
				Element.TextAlignment = nextProps.TextAlignment.Value.Value;
			}
			if (nextProps.SelectedText.HasValue)
			{
				Element.SelectedText = nextProps.SelectedText.Value.Value;
			}
			if (nextProps.SelectionLength.HasValue)
			{
				Element.SelectionLength = nextProps.SelectionLength.Value.Value;
			}
			if (nextProps.SelectionStart.HasValue)
			{
				Element.SelectionStart = nextProps.SelectionStart.Value.Value;
			}
			if (nextProps.CaretIndex.HasValue)
			{
				Element.CaretIndex = nextProps.CaretIndex.Value.Value;
			}
			if (nextProps.TextDecorations.HasValue)
			{
				Element.TextDecorations = nextProps.TextDecorations.Value.Value;
			}
		}
	}
}
