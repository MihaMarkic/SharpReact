
namespace SharpReact.Wpf.Components
{
	public  class Path<TProps>: Shape<TProps, System.Windows.Shapes.Path>
		where TProps : Props.Path
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Shapes.Path();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Data.HasValue)
			{
				Element.Data = nextProps.Data.Value.Value;
			}
		}
	}
}
