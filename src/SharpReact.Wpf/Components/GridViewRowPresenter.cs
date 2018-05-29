
namespace SharpReact.Wpf.Components
{
	public  class GridViewRowPresenter<TProps, TElement>: GridViewRowPresenterBase<TProps, TElement>
		where TProps : Props.GridViewRowPresenter
		where TElement : System.Windows.Controls.GridViewRowPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.GridViewRowPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
