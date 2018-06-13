using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class WebView<TProps, TElement>: AbsoluteLayout<TProps, TElement>
		where TProps : Props.WebView
		where TElement : global::Android.Webkit.WebView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Webkit.WebView(context);
		}
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
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.WebView.Views), nameof(SharpReact.Android.Props.WebView));
				ElementSynchronizer.SyncElements(Element, elements);
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
