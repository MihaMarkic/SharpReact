using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RadioButton<TProps, TElement>: CompoundButton<TProps, TElement>
		where TProps : Props.RadioButton
		where TElement : global::Android.Widget.RadioButton
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RadioButton(context);
		}
	}
}
