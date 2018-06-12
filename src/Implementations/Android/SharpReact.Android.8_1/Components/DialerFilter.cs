using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class DialerFilter<TProps, TElement>: RelativeLayout<TProps, TElement>
		where TProps : Props.DialerFilter
		where TElement : global::Android.Widget.DialerFilter
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Mode.HasValue)
			{
				Element.Mode = nextProps.Mode.Value.Value;
			}
		}
	}
}