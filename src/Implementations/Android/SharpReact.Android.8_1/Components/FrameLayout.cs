using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class FrameLayout<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.FrameLayout
		where TElement : global::Android.Widget.FrameLayout
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.FrameLayout(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Foreground.HasValue)
			{
				Element.Foreground = nextProps.Foreground.Value.Value;
			}
			if (nextProps.ForegroundTintList.HasValue)
			{
				Element.ForegroundTintList = nextProps.ForegroundTintList.Value.Value;
			}
			if (nextProps.ForegroundTintMode.HasValue)
			{
				Element.ForegroundTintMode = nextProps.ForegroundTintMode.Value.Value;
			}
			if (nextProps.MeasureAllChildren.HasValue)
			{
				Element.MeasureAllChildren = nextProps.MeasureAllChildren.Value.Value;
			}
		}
	}
}
