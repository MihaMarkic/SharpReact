
namespace SharpReact.Wpf.Components
{
	public abstract class Adorner<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Adorner
		where TElement : System.Windows.Documents.Adorner
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsClipEnabled.HasValue)
			{
				Element.IsClipEnabled = nextProps.IsClipEnabled.Value.Value;
			}
		}
	}
}
