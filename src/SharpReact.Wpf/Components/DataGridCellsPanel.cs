
namespace SharpReact.Wpf.Components
{
	public  class DataGridCellsPanel<TProps, TElement>: VirtualizingPanel<TProps, TElement>
		where TProps : Props.DataGridCellsPanel
		where TElement : System.Windows.Controls.DataGridCellsPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.DataGridCellsPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
