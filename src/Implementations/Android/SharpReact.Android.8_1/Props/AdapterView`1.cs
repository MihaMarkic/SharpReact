using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract partial class AdapterView<T>: AdapterView
		where T: global::Android.Widget.IAdapter 
	{
		public ReactParam<T>? Adapter { get; set; }
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
