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
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.Spinner.Views), nameof(SharpReact.Android.Props.Spinner));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
