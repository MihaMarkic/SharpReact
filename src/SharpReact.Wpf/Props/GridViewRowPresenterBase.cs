using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class GridViewRowPresenterBase: FrameworkElement
	{
		public ReactParam<System.Windows.Controls.GridViewColumnCollection>? Columns { get; set; }
	}
}
