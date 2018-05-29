
namespace SharpReact.Wpf.Components
{
	public  class DocumentReference<TProps>: FrameworkElement<TProps, System.Windows.Documents.DocumentReference>
		where TProps : Props.DocumentReference
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Documents.DocumentReference();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
		}
	}
}
