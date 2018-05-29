
namespace SharpReact.Wpf.Components
{
	public  class ListViewItem<TProps, TElement>: ListBoxItem<TProps, TElement>
		where TProps : Props.ListViewItem
		where TElement : System.Windows.Controls.ListViewItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ListViewItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
