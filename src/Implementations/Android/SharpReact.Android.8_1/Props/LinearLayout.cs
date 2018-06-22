using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class LinearLayout: ViewGroup
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
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return BaselineAligned;
				yield return BaselineAlignedChildIndex;
				yield return DividerPadding;
				yield return MeasureWithLargestChildEnabled;
				yield return Orientation;
				yield return ShowDividers;
				yield return WeightSum;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
