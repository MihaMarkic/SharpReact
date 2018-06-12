using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class ViewFlipper: ViewAnimator
	{
		public ReactParam<global::System.Boolean>? AutoStart { get; set; }
	}
}
