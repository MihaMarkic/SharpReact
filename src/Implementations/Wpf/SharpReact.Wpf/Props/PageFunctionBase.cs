using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class PageFunctionBase: Page
	{
		public ReactParam<global::System.Boolean>? RemoveFromJournal { get; set; }
	}
}
