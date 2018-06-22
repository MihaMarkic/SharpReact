using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class ActionBarContextView<TProps, TElement>: AbsActionBarView<TProps, TElement>
		where TProps : Props.ActionBarContextView
		where TElement : global::Android.Support.V7.Widget.ActionBarContextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.ActionBarContextView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateActionBarContextViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignActionBarContextViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignActionBarContextViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateActionBarContextViewWithInstanceProperties(element, null, props);
		}
		static void UpdateActionBarContextViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.SubtitleFormatted.HasValue)
			{
				element.SubtitleFormatted = nextProps.SubtitleFormatted.Value.Value;
			}
			if (nextProps.Subtitle.HasValue)
			{
				element.Subtitle = nextProps.Subtitle.Value.Value;
			}
			if (nextProps.TitleFormatted.HasValue)
			{
				element.TitleFormatted = nextProps.TitleFormatted.Value.Value;
			}
			if (nextProps.Title.HasValue)
			{
				element.Title = nextProps.Title.Value.Value;
			}
			if (nextProps.TitleOptional.HasValue)
			{
				element.TitleOptional = nextProps.TitleOptional.Value.Value;
			}
		}
	}
}
