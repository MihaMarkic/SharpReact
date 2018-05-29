using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class InkPresenter: Decorator
	{
		public ReactParam<System.Windows.Ink.StrokeCollection>? Strokes { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.InkPresenter<InkPresenter, System.Windows.Controls.InkPresenter>();
		}
	}
}
