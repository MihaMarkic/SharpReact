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
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateCheckedTextViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateCheckedTextViewWithInstanceProperties(element, null, props);
		}
		static void UpdateCheckedTextViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.CheckMarkTintList.HasValue)
			{
				element.CheckMarkTintList = nextProps.CheckMarkTintList.Value.Value;
			}
			if (nextProps.CheckMarkTintMode.HasValue)
			{
				element.CheckMarkTintMode = nextProps.CheckMarkTintMode.Value.Value;
			}
			if (nextProps.Checked.HasValue)
			{
				element.Checked = nextProps.Checked.Value.Value;
			}
		}
	}
}
