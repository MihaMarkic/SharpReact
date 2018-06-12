using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class AbsSpinner: AdapterView<global::Android.Widget.ISpinnerAdapter>
	{
		public ReactParam<global::Android.Widget.ISpinnerAdapter>? Adapter { get; set; }
	}
}
