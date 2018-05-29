
namespace SharpReact.Wpf.Components
{
	public  class DataGridCellsPresenter<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.DataGridCellsPresenter
		where TElement : System.Windows.Controls.Primitives.DataGridCellsPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DataGridCellsPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
