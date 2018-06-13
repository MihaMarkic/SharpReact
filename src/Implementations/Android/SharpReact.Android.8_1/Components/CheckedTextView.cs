using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class CheckedTextView<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.CheckedTextView
		where TElement : global::Android.Widget.CheckedTextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.CheckedTextView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.CheckMarkTintList.HasValue)
			{
				Element.CheckMarkTintList = nextProps.CheckMarkTintList.Value.Value;
			}
			if (nextProps.CheckMarkTintMode.HasValue)
			{
				Element.CheckMarkTintMode = nextProps.CheckMarkTintMode.Value.Value;
			}
			if (nextProps.Checked.HasValue)
			{
				Element.Checked = nextProps.Checked.Value.Value;
			}
		}
	}
}
