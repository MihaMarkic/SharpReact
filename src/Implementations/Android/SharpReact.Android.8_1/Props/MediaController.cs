using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class MediaController: FrameLayout
	{
		public System.EventHandler NextClick { get; set; }
		public System.EventHandler PreviousClick { get; set; }
	}
}
