
namespace SharpReact.Wpf.Components
{
	public  class Line<TProps>: Shape<TProps, System.Windows.Shapes.Line>
		where TProps : Props.Line
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Shapes.Line();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.X1.HasValue)
			{
				Element.X1 = nextProps.X1.Value.Value;
			}
			if (nextProps.Y1.HasValue)
			{
				Element.Y1 = nextProps.Y1.Value.Value;
			}
			if (nextProps.X2.HasValue)
			{
				Element.X2 = nextProps.X2.Value.Value;
			}
			if (nextProps.Y2.HasValue)
			{
				Element.Y2 = nextProps.Y2.Value.Value;
			}
		}
	}
}
