
namespace SharpReact.Wpf.Components
{
	public  class GroupItem<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.GroupItem
		where TElement : System.Windows.Controls.GroupItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.GroupItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
