using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class QuickContactBadge<TProps, TElement>: ImageView<TProps, TElement>
		where TProps : Props.QuickContactBadge
		where TElement : global::Android.Widget.QuickContactBadge
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
