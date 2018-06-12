using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class Spinner<TProps, TElement>: AbsSpinner<TProps, TElement>
		where TProps : Props.Spinner
		where TElement : global::Android.Widget.Spinner
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.DropDownHorizontalOffset.HasValue)
			{
				Element.DropDownHorizontalOffset = nextProps.DropDownHorizontalOffset.Value.Value;
			}
			if (nextProps.DropDownVerticalOffset.HasValue)
			{
				Element.DropDownVerticalOffset = nextProps.DropDownVerticalOffset.Value.Value;
			}
			if (nextProps.DropDownWidth.HasValue)
			{
				Element.DropDownWidth = nextProps.DropDownWidth.Value.Value;
			}
			if (nextProps.PromptFormatted.HasValue)
			{
				Element.PromptFormatted = nextProps.PromptFormatted.Value.Value;
			}
			if (nextProps.Prompt.HasValue)
			{
				Element.Prompt = nextProps.Prompt.Value.Value;
			}
		}
	}
}
