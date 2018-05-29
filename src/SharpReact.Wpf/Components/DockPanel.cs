
namespace SharpReact.Wpf.Components
{
	public  class DockPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.DockPanel
		where TElement : System.Windows.Controls.DockPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.DockPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.LastChildFill.HasValue)
			{
				Element.LastChildFill = nextProps.LastChildFill.Value.Value;
			}
		}
	}
}
