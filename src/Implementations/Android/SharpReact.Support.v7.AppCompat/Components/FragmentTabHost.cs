using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class FragmentTabHost<TProps, TElement>: TabHost<TProps, TElement>
		where TProps : Props.FragmentTabHost
		where TElement : global::Android.Support.V4.App.FragmentTabHost
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V4.App.FragmentTabHost(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignFragmentTabHostProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
