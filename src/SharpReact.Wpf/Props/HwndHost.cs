using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class HwndHost: FrameworkElement
	{
		public System.Windows.Interop.HwndSourceHook MessageHook { get; set; }
		public System.Windows.DpiChangedEventHandler DpiChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			throw new System.NotImplementedException();
		}
	}
}
