
namespace SharpReact.Wpf.Components
{
	public  class ResizeGrip<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.ResizeGrip
		where TElement : System.Windows.Controls.Primitives.ResizeGrip
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.ResizeGrip();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
