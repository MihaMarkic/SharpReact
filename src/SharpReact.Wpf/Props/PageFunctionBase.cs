using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class PageFunctionBase: Page
	{
		public ReactParam<System.Boolean>? RemoveFromJournal { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			throw new System.NotImplementedException();
		}
	}
}
