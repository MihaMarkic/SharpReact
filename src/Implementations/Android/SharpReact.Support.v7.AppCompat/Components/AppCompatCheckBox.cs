using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class AppCompatCheckBox<TProps, TElement>: CheckBox<TProps, TElement>
		where TProps : Props.AppCompatCheckBox
		where TElement : global::Android.Support.V7.Widget.AppCompatCheckBox
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.AppCompatCheckBox(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAppCompatCheckBoxWithInstanceProperties(Element, previous, nextProps);
			PostAssignAppCompatCheckBoxProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAppCompatCheckBoxProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAppCompatCheckBoxWithInstanceProperties(element, null, props);
		}
		static void UpdateAppCompatCheckBoxWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.SupportButtonTintList.HasValue)
			{
				element.SupportButtonTintList = nextProps.SupportButtonTintList.Value.Value;
			}
			if (nextProps.SupportButtonTintMode.HasValue)
			{
				element.SupportButtonTintMode = nextProps.SupportButtonTintMode.Value.Value;
			}
		}
	}
}
