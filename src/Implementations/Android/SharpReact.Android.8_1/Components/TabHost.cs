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
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.CurrentTab.HasValue)
			{
				Element.CurrentTab = nextProps.CurrentTab.Value.Value;
			}
			if (!ReferenceEquals(previous?.TabChanged, null) && ReferenceEquals(nextProps.TabChanged, null))
			{
				Element.TabChanged -= nextProps.TabChanged;
			}
			if (ReferenceEquals(previous?.TabChanged, null) && !ReferenceEquals(nextProps.TabChanged, null))
			{
				Element.TabChanged += nextProps.TabChanged;
			}
		}
	}
}
