using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class ImageButton<TProps, TElement>: ImageView<TProps, TElement>
		where TProps : Props.ImageButton
		where TElement : global::Android.Widget.ImageButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.ImageButton(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
