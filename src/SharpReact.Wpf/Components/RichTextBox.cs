
namespace SharpReact.Wpf.Components
{
	public  class RichTextBox<TProps, TElement>: TextBoxBase<TProps, TElement>
		where TProps : Props.RichTextBox
		where TElement : System.Windows.Controls.RichTextBox
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.RichTextBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
