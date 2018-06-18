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
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateWebViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateWebViewWithInstanceProperties(element, null, props);
		}
		static void UpdateWebViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Certificate.HasValue)
			{
				element.Certificate = nextProps.Certificate.Value.Value;
			}
			if (nextProps.TextClassifier.HasValue)
			{
				element.TextClassifier = nextProps.TextClassifier.Value.Value;
			}
			if (!(previous?.Download is null) && nextProps.Download is null)
			{
				element.Download -= nextProps.Download;
			}
			if (previous?.Download is null && !(nextProps.Download is null))
			{
				element.Download += nextProps.Download;
			}
			if (!(previous?.Find is null) && nextProps.Find is null)
			{
				element.Find -= nextProps.Find;
			}
			if (previous?.Find is null && !(nextProps.Find is null))
			{
				element.Find += nextProps.Find;
			}
			if (!(previous?.Picture is null) && nextProps.Picture is null)
			{
				element.Picture -= nextProps.Picture;
			}
			if (previous?.Picture is null && !(nextProps.Picture is null))
			{
				element.Picture += nextProps.Picture;
			}
		}
	}
}
