using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ScrollView<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.ScrollView
		where TElement : global::Android.Widget.ScrollView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ScrollView(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateScrollViewWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateScrollViewWithInstanceProperties(element, null, props);
		}
		static void UpdateScrollViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.FillViewport.HasValue)
			{
				element.FillViewport = nextProps.FillViewport.Value.Value;
			}
			if (nextProps.SmoothScrollingEnabled.HasValue)
			{
				element.SmoothScrollingEnabled = nextProps.SmoothScrollingEnabled.Value.Value;
			}
		}
	}
}
