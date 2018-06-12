using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AnalogClock<TProps, TElement>: View<TProps, TElement>
		where TProps : Props.AnalogClock
		where TElement : global::Android.Widget.AnalogClock
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
