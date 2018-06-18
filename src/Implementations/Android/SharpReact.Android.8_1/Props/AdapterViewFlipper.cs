using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class AdapterViewFlipper: AdapterViewAnimator
	{
		public ReactParam<global::System.Boolean>? AutoStart { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AdapterViewFlipper<AdapterViewFlipper, global::Android.Widget.AdapterViewFlipper>();
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
