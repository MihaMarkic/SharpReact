using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TableRow: LinearLayout
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TableRow<TableRow, global::Android.Widget.TableRow>();
		}
	}
}
