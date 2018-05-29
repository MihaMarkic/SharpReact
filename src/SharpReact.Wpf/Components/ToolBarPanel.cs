
namespace SharpReact.Wpf.Components
{
	public  class ToolBarPanel<TProps, TElement>: StackPanel<TProps, TElement>
		where TProps : Props.ToolBarPanel
		where TElement : System.Windows.Controls.Primitives.ToolBarPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.ToolBarPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
