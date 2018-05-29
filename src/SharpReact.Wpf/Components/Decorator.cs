
namespace SharpReact.Wpf.Components
{
	public  class Decorator<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Decorator
		where TElement : System.Windows.Controls.Decorator
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Decorator();
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
