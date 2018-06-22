using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public abstract partial class AbsActionBarView: ViewGroup
	{
		public ReactParam<global::System.Int32>? ContentHeight { get; set; }
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return ContentHeight;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
