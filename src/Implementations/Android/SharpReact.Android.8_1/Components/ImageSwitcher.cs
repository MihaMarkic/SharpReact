using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ImageSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.ImageSwitcher
		where TElement : global::Android.Widget.ImageSwitcher
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
