using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Image<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Image
		where TElement : System.Windows.Controls.Image, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
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
			if (!ReferenceEquals(previous?.ImageFailed, null) && ReferenceEquals(nextProps.ImageFailed, null))
			{
				Element.ImageFailed -= nextProps.ImageFailed;
			}
			if (ReferenceEquals(previous?.ImageFailed, null) && !ReferenceEquals(nextProps.ImageFailed, null))
			{
				Element.ImageFailed += nextProps.ImageFailed;
			}
			if (!ReferenceEquals(previous?.DpiChanged, null) && ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged -= nextProps.DpiChanged;
			}
			if (ReferenceEquals(previous?.DpiChanged, null) && !ReferenceEquals(nextProps.DpiChanged, null))
			{
				Element.DpiChanged += nextProps.DpiChanged;
			}
		}
	}
}
