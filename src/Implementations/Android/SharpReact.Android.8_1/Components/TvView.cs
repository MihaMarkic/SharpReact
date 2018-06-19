using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class TvView<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.TvView
		where TElement : global::Android.Media.TV.TvView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Media.TV.TvView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignTvViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
