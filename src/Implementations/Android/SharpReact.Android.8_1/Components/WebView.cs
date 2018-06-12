using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class WebView<TProps, TElement>: AbsoluteLayout<TProps, TElement>
		where TProps : Props.WebView
		where TElement : global::Android.Webkit.WebView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Certificate.HasValue)
			{
				Element.Certificate = nextProps.Certificate.Value.Value;
			}
			if (nextProps.TextClassifier.HasValue)
			{
				Element.TextClassifier = nextProps.TextClassifier.Value.Value;
			}
			if (!ReferenceEquals(previous?.Download, null) && ReferenceEquals(nextProps.Download, null))
			{
				Element.Download -= nextProps.Download;
			}
			if (ReferenceEquals(previous?.Download, null) && !ReferenceEquals(nextProps.Download, null))
			{
				Element.Download += nextProps.Download;
			}
			if (!ReferenceEquals(previous?.Find, null) && ReferenceEquals(nextProps.Find, null))
			{
				Element.Find -= nextProps.Find;
			}
			if (ReferenceEquals(previous?.Find, null) && !ReferenceEquals(nextProps.Find, null))
			{
				Element.Find += nextProps.Find;
			}
			if (!ReferenceEquals(previous?.Picture, null) && ReferenceEquals(nextProps.Picture, null))
			{
				Element.Picture -= nextProps.Picture;
			}
			if (ReferenceEquals(previous?.Picture, null) && !ReferenceEquals(nextProps.Picture, null))
			{
				Element.Picture += nextProps.Picture;
			}
		}
	}
}
