using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class Space<TProps>: View<TProps, global::Android.Widget.Space>
		where TProps : Props.Space
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = new global::Android.Widget.Space(context);
		}
		partial void InitElement(global::Android.Widget.Space element);
		partial void PostAssignSpaceProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
