
namespace SharpReact.Wpf.Components
{
	public  class TabPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.TabPanel
		where TElement : System.Windows.Controls.Primitives.TabPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.TabPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
