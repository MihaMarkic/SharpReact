using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class AppCompatMultiAutoCompleteTextView<TProps, TElement>: MultiAutoCompleteTextView<TProps, TElement>
		where TProps : Props.AppCompatMultiAutoCompleteTextView
		where TElement : global::Android.Support.V7.Widget.AppCompatMultiAutoCompleteTextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.AppCompatMultiAutoCompleteTextView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAppCompatMultiAutoCompleteTextViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignAppCompatMultiAutoCompleteTextViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAppCompatMultiAutoCompleteTextViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAppCompatMultiAutoCompleteTextViewWithInstanceProperties(element, null, props);
		}
		static void UpdateAppCompatMultiAutoCompleteTextViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.SupportBackgroundTintList.HasValue)
			{
				element.SupportBackgroundTintList = nextProps.SupportBackgroundTintList.Value.Value;
			}
			if (nextProps.SupportBackgroundTintMode.HasValue)
			{
				element.SupportBackgroundTintMode = nextProps.SupportBackgroundTintMode.Value.Value;
			}
		}
	}
}
