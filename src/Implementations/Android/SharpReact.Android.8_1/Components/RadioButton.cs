using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RadioButton<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.RadioButton
		where TElement : global::Android.Widget.RadioButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RadioButton(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
