using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class FrameLayout: ViewGroup
	{
		public ReactParam<global::System.Boolean>? MeasureAllChildren { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FrameLayout<FrameLayout, global::Android.Widget.FrameLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return MeasureAllChildren;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
