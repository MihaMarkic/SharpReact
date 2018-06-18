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
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateFrameLayoutWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateFrameLayoutWithInstanceProperties(element, null, props);
		}
		static void UpdateFrameLayoutWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Foreground.HasValue)
			{
				element.Foreground = nextProps.Foreground.Value.Value;
			}
			if (nextProps.ForegroundTintList.HasValue)
			{
				element.ForegroundTintList = nextProps.ForegroundTintList.Value.Value;
			}
			if (nextProps.ForegroundTintMode.HasValue)
			{
				element.ForegroundTintMode = nextProps.ForegroundTintMode.Value.Value;
			}
			if (nextProps.MeasureAllChildren.HasValue)
			{
				element.MeasureAllChildren = nextProps.MeasureAllChildren.Value.Value;
			}
		}
	}
}
