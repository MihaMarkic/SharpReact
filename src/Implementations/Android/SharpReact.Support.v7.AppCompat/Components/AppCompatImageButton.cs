using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class AppCompatImageButton<TProps, TElement>: ImageButton<TProps, TElement>
		where TProps : Props.AppCompatImageButton
		where TElement : global::Android.Support.V7.Widget.AppCompatImageButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.AppCompatImageButton(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAppCompatImageButtonWithInstanceProperties(Element, previous, nextProps);
			PostAssignAppCompatImageButtonProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAppCompatImageButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAppCompatImageButtonWithInstanceProperties(element, null, props);
		}
		static void UpdateAppCompatImageButtonWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.SupportBackgroundTintList.HasValue)
			{
				element.SupportBackgroundTintList = nextProps.SupportBackgroundTintList.Value.Value;
			}
			if (nextProps.SupportBackgroundTintMode.HasValue)
			{
				element.SupportBackgroundTintMode = nextProps.SupportBackgroundTintMode.Value.Value;
			}
			if (nextProps.SupportImageTintList.HasValue)
			{
				element.SupportImageTintList = nextProps.SupportImageTintList.Value.Value;
			}
			if (nextProps.SupportImageTintMode.HasValue)
			{
				element.SupportImageTintMode = nextProps.SupportImageTintMode.Value.Value;
			}
		}
	}
}
