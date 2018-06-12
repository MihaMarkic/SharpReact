using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class HorizontalScrollView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.HorizontalScrollView
		where TElement : global::Android.Widget.HorizontalScrollView
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
