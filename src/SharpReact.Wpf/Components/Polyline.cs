
namespace SharpReact.Wpf.Components
{
	public  class Polyline<TProps>: Shape<TProps, System.Windows.Shapes.Polyline>
		where TProps : Props.Polyline
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Shapes.Polyline();
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
