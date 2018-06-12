using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class ScrollView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.ScrollView
		where TElement : global::Android.Widget.ScrollView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.FillViewport.HasValue)
			{
				Element.FillViewport = nextProps.FillViewport.Value.Value;
			}
			if (nextProps.SmoothScrollingEnabled.HasValue)
			{
				Element.SmoothScrollingEnabled = nextProps.SmoothScrollingEnabled.Value.Value;
			}
		}
	}
}
