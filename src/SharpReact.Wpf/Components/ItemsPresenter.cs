
namespace SharpReact.Wpf.Components
{
	public  class ItemsPresenter<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.ItemsPresenter
		where TElement : System.Windows.Controls.ItemsPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ItemsPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
