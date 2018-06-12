using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class TabWidget<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.TabWidget
		where TElement : global::Android.Widget.TabWidget
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.StripEnabled.HasValue)
			{
				Element.StripEnabled = nextProps.StripEnabled.Value.Value;
			}
		}
	}
}
