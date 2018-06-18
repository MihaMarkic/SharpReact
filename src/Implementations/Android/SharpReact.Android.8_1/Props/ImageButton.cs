using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ImageButton: ImageView
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ImageButton<ImageButton, global::Android.Widget.ImageButton>();
		}
	}
}
