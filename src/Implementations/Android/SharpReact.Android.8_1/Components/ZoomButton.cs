using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ZoomButton<TProps, TElement>: ImageButton<TProps, TElement>
		where TProps : Props.ZoomButton
		where TElement : global::Android.Widget.ZoomButton
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}