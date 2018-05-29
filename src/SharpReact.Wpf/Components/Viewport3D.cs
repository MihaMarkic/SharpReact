
namespace SharpReact.Wpf.Components
{
	public  class Viewport3D<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Viewport3D
		where TElement : System.Windows.Controls.Viewport3D
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Viewport3D();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Camera.HasValue)
			{
				Element.Camera = nextProps.Camera.Value.Value;
			}
		}
	}
}
