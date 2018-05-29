
namespace SharpReact.Wpf.Components
{
	public  class ComboBoxItem<TProps, TElement>: ListBoxItem<TProps, TElement>
		where TProps : Props.ComboBoxItem
		where TElement : System.Windows.Controls.ComboBoxItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ComboBoxItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
