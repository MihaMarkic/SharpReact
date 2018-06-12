using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class TextSwitcher<TProps, TElement>: ViewSwitcher<TProps, TElement>
		where TProps : Props.TextSwitcher
		where TElement : global::Android.Widget.TextSwitcher
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
