using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract partial class AbsSpinner: AdapterView<global::Android.Widget.ISpinnerAdapter>
	{
		public ReactParam<global::Android.Widget.ISpinnerAdapter>? Adapter { get; set; }
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Adapter;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
