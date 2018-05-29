
namespace SharpReact.Wpf.Components
{
	public  class Polygon<TProps>: Shape<TProps, System.Windows.Shapes.Polygon>
		where TProps : Props.Polygon
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Shapes.Polygon();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Points.HasValue)
			{
				Element.Points = nextProps.Points.Value.Value;
			}
			if (nextProps.FillRule.HasValue)
			{
				Element.FillRule = nextProps.FillRule.Value.Value;
			}
		}
	}
}
