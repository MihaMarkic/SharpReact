using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class Adorner: FrameworkElement
	{
		public ReactParam<System.Boolean>? IsClipEnabled { get; set; }
	}
}
