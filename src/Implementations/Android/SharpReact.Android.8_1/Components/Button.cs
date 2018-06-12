using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class Button<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.Button
		where TElement : global::Android.Widget.Button
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
