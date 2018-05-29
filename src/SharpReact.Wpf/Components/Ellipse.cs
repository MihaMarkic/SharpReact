
namespace SharpReact.Wpf.Components
{
	public  class Ellipse<TProps>: Shape<TProps, System.Windows.Shapes.Ellipse>
		where TProps : Props.Ellipse
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Shapes.Ellipse();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
