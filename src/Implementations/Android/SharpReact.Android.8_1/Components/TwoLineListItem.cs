using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class TwoLineListItem<TProps, TElement>: RelativeLayout<TProps, TElement>
		where TProps : Props.TwoLineListItem
		where TElement : global::Android.Widget.TwoLineListItem
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
