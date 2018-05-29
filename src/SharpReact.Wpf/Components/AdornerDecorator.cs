
namespace SharpReact.Wpf.Components
{
	public  class AdornerDecorator<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.AdornerDecorator
		where TElement : System.Windows.Documents.AdornerDecorator
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Documents.AdornerDecorator();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
		}
	}
}
