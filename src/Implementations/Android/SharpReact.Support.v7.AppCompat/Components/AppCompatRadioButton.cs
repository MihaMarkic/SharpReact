using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class AppCompatRadioButton<TProps, TElement>: RadioButton<TProps, TElement>
		where TProps : Props.AppCompatRadioButton
		where TElement : global::Android.Support.V7.Widget.AppCompatRadioButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.AppCompatRadioButton(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAppCompatRadioButtonWithInstanceProperties(Element, previous, nextProps);
			PostAssignAppCompatRadioButtonProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAppCompatRadioButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAppCompatRadioButtonWithInstanceProperties(element, null, props);
		}
		static void UpdateAppCompatRadioButtonWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
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
