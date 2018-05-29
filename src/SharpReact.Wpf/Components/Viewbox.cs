
namespace SharpReact.Wpf.Components
{
	public  class Viewbox<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.Viewbox
		where TElement : System.Windows.Controls.Viewbox
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Viewbox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
			if (nextProps.Stretch.HasValue)
			{
				Element.Stretch = nextProps.Stretch.Value.Value;
			}
			if (nextProps.StretchDirection.HasValue)
			{
				Element.StretchDirection = nextProps.StretchDirection.Value.Value;
			}
		}
	}
}
