using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class RSTextureView<TProps, TElement>: TextureView<TProps, TElement>
		where TProps : Props.RSTextureView
		where TElement : global::Android.Renderscripts.RSTextureView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Renderscripts.RSTextureView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		partial void PostAssignRSTextureViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
	}
}
