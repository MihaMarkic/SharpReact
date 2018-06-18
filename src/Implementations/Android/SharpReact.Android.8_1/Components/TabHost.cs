using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TabHost<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.TabHost
		where TElement : global::Android.Widget.TabHost
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TabHost(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateTabHostWithInstanceProperties(Element, previous, nextProps);
		}
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateTabHostWithInstanceProperties(element, null, props);
		}
		static void UpdateTabHostWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.CurrentTab.HasValue)
			{
				element.CurrentTab = nextProps.CurrentTab.Value.Value;
			}
			if (!(previous?.TabChanged is null) && nextProps.TabChanged is null)
			{
				element.TabChanged -= nextProps.TabChanged;
			}
			if (previous?.TabChanged is null && !(nextProps.TabChanged is null))
			{
				element.TabChanged += nextProps.TabChanged;
			}
		}
	}
}
