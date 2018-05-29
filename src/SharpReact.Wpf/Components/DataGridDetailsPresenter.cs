
namespace SharpReact.Wpf.Components
{
	public  class DataGridDetailsPresenter<TProps, TElement>: ContentPresenter<TProps, TElement>
		where TProps : Props.DataGridDetailsPresenter
		where TElement : System.Windows.Controls.Primitives.DataGridDetailsPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DataGridDetailsPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
