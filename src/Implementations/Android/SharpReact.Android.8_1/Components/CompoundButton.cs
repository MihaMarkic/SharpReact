using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class CompoundButton<TProps, TElement>: Button<TProps, TElement>
		where TProps : Props.CompoundButton
		where TElement : global::Android.Widget.CompoundButton
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateCompoundButtonWithInstanceProperties(Element, previous, nextProps);
			PostAssignCompoundButtonProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignCompoundButtonProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateCompoundButtonWithInstanceProperties(element, null, props);
		}
		static void UpdateCompoundButtonWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.ButtonTintList.HasValue)
			{
				element.ButtonTintList = nextProps.ButtonTintList.Value.Value;
			}
			if (nextProps.ButtonTintMode.HasValue)
			{
				element.ButtonTintMode = nextProps.ButtonTintMode.Value.Value;
			}
			if (nextProps.Checked.HasValue)
			{
				element.Checked = nextProps.Checked.Value.Value;
			}
			if (!(previous?.CheckedChange is null) && nextProps.CheckedChange is null)
			{
				element.CheckedChange -= nextProps.CheckedChange;
			}
			if (previous?.CheckedChange is null && !(nextProps.CheckedChange is null))
			{
				element.CheckedChange += nextProps.CheckedChange;
			}
		}
	}
}
