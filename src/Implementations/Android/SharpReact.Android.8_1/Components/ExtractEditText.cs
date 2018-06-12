using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ExtractEditText<TProps, TElement>: EditText<TProps, TElement>
		where TProps : Props.ExtractEditText
		where TElement : global::Android.InputMethodServices.ExtractEditText
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
