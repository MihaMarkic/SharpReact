using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ContentLoadingProgressBar<TProps, TElement>: ProgressBar<TProps, TElement>
		where TProps : Props.ContentLoadingProgressBar
		where TElement : global::Android.Support.V4.Widget.ContentLoadingProgressBar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.Widget.ContentLoadingProgressBar(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignContentLoadingProgressBarProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
