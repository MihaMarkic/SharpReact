using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class RepeatButton: ButtonBase
	{
		public ReactParam<System.Int32>? Delay { get; set; }
		public ReactParam<System.Int32>? Interval { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.RepeatButton<RepeatButton, System.Windows.Controls.Primitives.RepeatButton>();
		}
	}
}
