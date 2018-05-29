
namespace SharpReact.Wpf.Components
{
	public  class Canvas<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.Canvas
		where TElement : System.Windows.Controls.Canvas
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Canvas();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
