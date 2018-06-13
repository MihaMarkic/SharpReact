using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class MediaController: FrameLayout
	{
		public System.EventHandler NextClick { get; set; }
		public System.EventHandler PreviousClick { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.MediaController<MediaController, global::Android.Widget.MediaController>();
		}
	}
}
