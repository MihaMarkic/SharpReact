
namespace SharpReact.Wpf.Components
{
	public  class StatusBarItem<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.StatusBarItem
		where TElement : System.Windows.Controls.Primitives.StatusBarItem
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.StatusBarItem();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
