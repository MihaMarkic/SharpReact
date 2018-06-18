using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract partial class AdapterViewAnimator: AdapterView
	{
		public ReactParam<global::Android.Widget.IAdapter>? Adapter { get; set; }
		public ReactParam<global::System.Int32>? DisplayedChild { get; set; }
		public ReactParam<global::Android.Animation.ObjectAnimator>? InAnimation { get; set; }
		public ReactParam<global::Android.Animation.ObjectAnimator>? OutAnimation { get; set; }
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Adapter;
				yield return DisplayedChild;
				yield return InAnimation;
				yield return OutAnimation;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
