
namespace SharpReact.Wpf.Components
{
	public abstract class Panel<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Panel
		where TElement : System.Windows.Controls.Panel
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.IsItemsHost.HasValue)
			{
				Element.IsItemsHost = nextProps.IsItemsHost.Value.Value;
			}
		}
	}
}
