using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class SeekBar<TProps, TElement>: AbsSeekBar<TProps, TElement>
		where TProps : Props.SeekBar
		where TElement : global::Android.Widget.SeekBar
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.SeekBar(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignSeekBarProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
