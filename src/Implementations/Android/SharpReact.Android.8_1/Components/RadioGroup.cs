using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class RadioGroup<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.RadioGroup
		where TElement : global::Android.Widget.RadioGroup
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.RadioGroup(context);
		}
	}
}
