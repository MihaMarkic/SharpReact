using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AbsoluteLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AbsoluteLayout
		where TElement : global::Android.Widget.AbsoluteLayout
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
