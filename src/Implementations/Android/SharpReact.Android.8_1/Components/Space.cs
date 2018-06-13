using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class Space<TProps>: View<TProps, global::Android.Widget.Space>
		where TProps : Props.Space
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = new global::Android.Widget.Space(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
		}
	}
}
