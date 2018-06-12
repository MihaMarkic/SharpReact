using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class EditText<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.EditText
		where TElement : global::Android.Widget.EditText
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}