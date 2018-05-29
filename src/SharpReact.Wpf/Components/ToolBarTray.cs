
namespace SharpReact.Wpf.Components
{
	public  class ToolBarTray<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.ToolBarTray
		where TElement : System.Windows.Controls.ToolBarTray
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ToolBarTray();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
			if (nextProps.IsLocked.HasValue)
			{
				Element.IsLocked = nextProps.IsLocked.Value.Value;
			}
		}
	}
}
