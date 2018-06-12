using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class Gallery<TProps, TElement>: AbsSpinner<TProps, TElement>
		where TProps : Props.Gallery
		where TElement : global::Android.Widget.Gallery
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
