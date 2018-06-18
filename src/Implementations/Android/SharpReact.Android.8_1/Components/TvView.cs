using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TvView<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.TvView
		where TElement : global::Android.Media.TV.TvView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Media.TV.TvView(context);
		}
	}
}
