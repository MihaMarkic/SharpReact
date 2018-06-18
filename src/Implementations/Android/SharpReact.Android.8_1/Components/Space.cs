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
	}
}
