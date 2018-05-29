
namespace SharpReact.Wpf.Components
{
	public  class DataGridRowsPresenter<TProps, TElement>: VirtualizingStackPanel<TProps, TElement>
		where TProps : Props.DataGridRowsPresenter
		where TElement : System.Windows.Controls.Primitives.DataGridRowsPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DataGridRowsPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
