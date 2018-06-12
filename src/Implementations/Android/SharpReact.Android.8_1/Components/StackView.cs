using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class StackView<TProps, TElement>: AdapterViewAnimator<TProps, TElement>
		where TProps : Props.StackView
		where TElement : global::Android.Widget.StackView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
