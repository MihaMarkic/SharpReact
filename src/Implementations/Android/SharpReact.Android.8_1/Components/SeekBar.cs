using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class SeekBar<TProps, TElement>: AbsSeekBar<TProps, TElement>
		where TProps : Props.SeekBar
		where TElement : global::Android.Widget.SeekBar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.SeekBar(context);
		}
	}
}
