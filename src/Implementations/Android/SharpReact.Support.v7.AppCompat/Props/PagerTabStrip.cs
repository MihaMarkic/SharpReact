using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class PagerTabStrip: PagerTitleStrip
	{
		public ReactParam<global::System.Boolean>? DrawFullUnderline { get; set; }
		public ReactParam<global::System.Int32>? TabIndicatorColor { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.PagerTabStrip<PagerTabStrip, global::Android.Support.V4.View.PagerTabStrip>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return DrawFullUnderline;
				yield return TabIndicatorColor;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
