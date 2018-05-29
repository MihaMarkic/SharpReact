using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class AdornerDecorator: Decorator
	{
		public ReactParam<System.Windows.UIElement>? Child { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AdornerDecorator<AdornerDecorator, System.Windows.Documents.AdornerDecorator>();
		}
	}
}
