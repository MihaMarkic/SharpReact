using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class MultiAutoCompleteTextView<TProps, TElement>: AutoCompleteTextView<TProps, TElement>
		where TProps : Props.MultiAutoCompleteTextView
		where TElement : global::Android.Widget.MultiAutoCompleteTextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.MultiAutoCompleteTextView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
