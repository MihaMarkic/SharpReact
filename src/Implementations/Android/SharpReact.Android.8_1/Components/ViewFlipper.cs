using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ViewFlipper<TProps, TElement>: ViewAnimator<TProps, TElement>
		where TProps : Props.ViewFlipper
		where TElement : global::Android.Widget.ViewFlipper
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.AutoStart.HasValue)
			{
				Element.AutoStart = nextProps.AutoStart.Value.Value;
			}
		}
	}
}
