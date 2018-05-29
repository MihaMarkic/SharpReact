
namespace SharpReact.Wpf.Components
{
	public  class DataGridColumnHeadersPresenter<TProps, TElement>: ItemsControl<TProps, TElement>
		where TProps : Props.DataGridColumnHeadersPresenter
		where TElement : System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DataGridColumnHeadersPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
