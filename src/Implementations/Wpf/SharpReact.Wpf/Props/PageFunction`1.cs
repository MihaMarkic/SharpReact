using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class PageFunction<T>: PageFunctionBase
	{
		public System.Windows.Navigation.ReturnEventHandler<T> Return { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.PageFunction<T, PageFunction<T>, System.Windows.Navigation.PageFunction<T>>();
		}
	}
}
