
namespace SharpReact.Wpf.Components
{
	public  class GridViewColumnHeader<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.GridViewColumnHeader
		where TElement : System.Windows.Controls.GridViewColumnHeader
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.GridViewColumnHeader();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
