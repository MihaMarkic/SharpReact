using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class DialerFilter<TProps, TElement>: RelativeLayout<TProps, TElement>
		where TProps : Props.DialerFilter
		where TElement : global::Android.Widget.DialerFilter
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.DialerFilter(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateDialerFilterWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateDialerFilterWithInstanceProperties(element, null, props);
		}
		static void UpdateDialerFilterWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Mode.HasValue)
			{
				element.Mode = nextProps.Mode.Value.Value;
			}
		}
	}
}
