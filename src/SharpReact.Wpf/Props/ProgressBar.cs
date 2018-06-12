using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ProgressBar: RangeBase
	{
		public ReactParam<global::System.Boolean>? IsIndeterminate { get; set; }
		public ReactParam<global::System.Windows.Controls.Orientation>? Orientation { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ProgressBar<ProgressBar, System.Windows.Controls.ProgressBar>();
		}
	}
}
