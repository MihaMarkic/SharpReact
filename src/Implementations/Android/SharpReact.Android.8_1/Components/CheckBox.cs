using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class CheckBox<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.CheckBox
		where TElement : global::Android.Widget.CheckBox
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.CheckBox(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
