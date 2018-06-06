using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class RichTextBox<TProps, TElement>: TextBoxBase<TProps, TElement>
		where TProps : Props.RichTextBox
		where TElement : System.Windows.Controls.RichTextBox, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Document.HasValue)
			{
				Element.Document = nextProps.Document.Value.Value;
			}
			if (nextProps.IsDocumentEnabled.HasValue)
			{
				Element.IsDocumentEnabled = nextProps.IsDocumentEnabled.Value.Value;
			}
			if (nextProps.CaretPosition.HasValue)
			{
				Element.CaretPosition = nextProps.CaretPosition.Value.Value;
			}
		}
	}
}
