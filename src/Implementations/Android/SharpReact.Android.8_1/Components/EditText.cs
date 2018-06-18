using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class EditText<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.EditText
		where TElement : global::Android.Widget.EditText
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.EditText(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
