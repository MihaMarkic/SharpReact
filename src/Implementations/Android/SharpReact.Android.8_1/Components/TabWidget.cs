using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TabWidget<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TabWidget
		where TElement : global::Android.Widget.TabWidget
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TabWidget(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.StripEnabled.HasValue)
			{
				Element.StripEnabled = nextProps.StripEnabled.Value.Value;
			}
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.TabWidget.Views), nameof(SharpReact.Android.Props.TabWidget));
				ElementSynchronizer.SyncElements(Element, elements);
			}
		}
	}
}
