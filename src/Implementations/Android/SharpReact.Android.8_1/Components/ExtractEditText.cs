using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ExtractEditText<TProps, TElement>: EditText<TProps, TElement>
		where TProps : Props.ExtractEditText
		where TElement : global::Android.InputMethodServices.ExtractEditText
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.InputMethodServices.ExtractEditText(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
