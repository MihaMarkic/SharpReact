using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class RSTextureView: TextureView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RSTextureView<RSTextureView, global::Android.Renderscripts.RSTextureView>();
		}
	}
}
