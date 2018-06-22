using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class PagerTitleStrip: ViewGroup
	{
		public ReactParam<global::System.Int32>? TextSpacing { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.PagerTitleStrip<PagerTitleStrip, global::Android.Support.V4.View.PagerTitleStrip>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return TextSpacing;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
