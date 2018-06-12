using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ViewSwitcher<TProps, TElement>: ViewAnimator<TProps, TElement>
		where TProps : Props.ViewSwitcher
		where TElement : global::Android.Widget.ViewSwitcher
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
