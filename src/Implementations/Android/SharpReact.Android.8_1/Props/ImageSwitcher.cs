using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class ImageSwitcher: ViewSwitcher
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ImageSwitcher<ImageSwitcher, global::Android.Widget.ImageSwitcher>();
		}
	}
}
