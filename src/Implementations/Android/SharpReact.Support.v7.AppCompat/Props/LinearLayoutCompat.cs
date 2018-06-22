using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class LinearLayoutCompat: ViewGroup
	{
		public ReactParam<global::System.Boolean>? BaselineAligned { get; set; }
		public ReactParam<global::System.Int32>? BaselineAlignedChildIndex { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? DividerDrawable { get; set; }
		public ReactParam<global::System.Int32>? DividerPadding { get; set; }
		public ReactParam<global::System.Int32>? Gravity { get; set; }
		public ReactParam<global::System.Boolean>? MeasureWithLargestChildEnabled { get; set; }
		public ReactParam<global::System.Int32>? Orientation { get; set; }
		public ReactParam<global::System.Int32>? ShowDividers { get; set; }
		public ReactParam<global::System.Single>? WeightSum { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.LinearLayoutCompat<LinearLayoutCompat, global::Android.Support.V7.Widget.LinearLayoutCompat>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return BaselineAligned;
				yield return BaselineAlignedChildIndex;
				yield return DividerDrawable;
				yield return DividerPadding;
				yield return Gravity;
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
