using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ViewFlipper: ViewAnimator
	{
		public ReactParam<global::System.Boolean>? AutoStart { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewFlipper<ViewFlipper, global::Android.Widget.ViewFlipper>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return AutoStart;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
