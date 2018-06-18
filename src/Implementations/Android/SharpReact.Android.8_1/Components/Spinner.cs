using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Spinner<TProps, TElement>: AbsSpinner<TProps, TElement>
		where TProps : Props.Spinner
		where TElement : global::Android.Widget.Spinner
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Spinner(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateSpinnerWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateSpinnerWithInstanceProperties(element, null, props);
		}
		static void UpdateSpinnerWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.DropDownHorizontalOffset.HasValue)
			{
				element.DropDownHorizontalOffset = nextProps.DropDownHorizontalOffset.Value.Value;
			}
			if (nextProps.DropDownVerticalOffset.HasValue)
			{
				element.DropDownVerticalOffset = nextProps.DropDownVerticalOffset.Value.Value;
			}
			if (nextProps.DropDownWidth.HasValue)
			{
				element.DropDownWidth = nextProps.DropDownWidth.Value.Value;
			}
			if (nextProps.PromptFormatted.HasValue)
			{
				element.PromptFormatted = nextProps.PromptFormatted.Value.Value;
			}
			if (nextProps.Prompt.HasValue)
			{
				element.Prompt = nextProps.Prompt.Value.Value;
			}
		}
	}
}
