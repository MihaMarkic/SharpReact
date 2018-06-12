using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class DigitalClock<TProps, TElement>: TextView<TProps, TElement>
		where TProps : Props.DigitalClock
		where TElement : global::Android.Widget.DigitalClock
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
