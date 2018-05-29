
namespace SharpReact.Wpf.Components
{
	public  class Image<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Image
		where TElement : System.Windows.Controls.Image
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Image();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
			if (nextProps.Stretch.HasValue)
			{
				Element.Stretch = nextProps.Stretch.Value.Value;
			}
			if (nextProps.StretchDirection.HasValue)
			{
				Element.StretchDirection = nextProps.StretchDirection.Value.Value;
			}
			if (!ReferenceEquals(Props?.ImageFailed, null) && ReferenceEquals(nextProps.ImageFailed, null))
			{
				Element.ImageFailed -= nextProps.ImageFailed;
			}
			if (ReferenceEquals(Props?.ImageFailed, null) && !ReferenceEquals(nextProps.ImageFailed, null))
			{
				Element.ImageFailed += nextProps.ImageFailed;
			}
			if (!ReferenceEquals(Props?.DpiChanged, null) && ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged -= nextProps.DpiChanged;
			}
			if (ReferenceEquals(Props?.DpiChanged, null) && !ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged += nextProps.DpiChanged;
			}
		}
	}
}
