using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class AdapterViewFlipper<TProps, TElement>: AdapterViewAnimator<TProps, TElement>
		where TProps : Props.AdapterViewFlipper
		where TElement : global::Android.Widget.AdapterViewFlipper
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AdapterViewFlipper(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.AutoStart.HasValue)
			{
				Element.AutoStart = nextProps.AutoStart.Value.Value;
			}
		}
	}
}
