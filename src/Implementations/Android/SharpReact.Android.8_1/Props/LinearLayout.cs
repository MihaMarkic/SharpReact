using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class LinearLayout: ViewGroup
	{
		public ReactParam<global::System.Boolean>? BaselineAligned { get; set; }
		public ReactParam<global::System.Int32>? BaselineAlignedChildIndex { get; set; }
		public ReactParam<global::System.Int32>? DividerPadding { get; set; }
		public ReactParam<global::System.Boolean>? MeasureWithLargestChildEnabled { get; set; }
		public ReactParam<global::Android.Widget.Orientation>? Orientation { get; set; }
		public ReactParam<global::Android.Widget.ShowDividers>? ShowDividers { get; set; }
		public ReactParam<global::System.Single>? WeightSum { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.LinearLayout<LinearLayout, global::Android.Widget.LinearLayout>();
		}
	}
}
