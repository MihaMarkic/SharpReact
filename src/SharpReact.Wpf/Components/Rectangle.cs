
namespace SharpReact.Wpf.Components
{
	public  class Rectangle<TProps>: Shape<TProps, System.Windows.Shapes.Rectangle>
		where TProps : Props.Rectangle
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Shapes.Rectangle();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.RadiusX.HasValue)
			{
				Element.RadiusX = nextProps.RadiusX.Value.Value;
			}
			if (nextProps.RadiusY.HasValue)
			{
				Element.RadiusY = nextProps.RadiusY.Value.Value;
			}
		}
	}
}
