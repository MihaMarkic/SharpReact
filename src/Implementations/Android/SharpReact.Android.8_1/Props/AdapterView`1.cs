using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class AdapterView<T>: AdapterView
		where T: global::Android.Widget.IAdapter 
	{
		public ReactParam<T>? Adapter { get; set; }
	}
}
