using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Gallery<TProps, TElement>: AbsSpinner<TProps, TElement>
		where TProps : Props.Gallery
		where TElement : global::Android.Widget.Gallery
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.Gallery(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
