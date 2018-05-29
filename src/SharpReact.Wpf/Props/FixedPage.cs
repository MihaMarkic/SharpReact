using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FixedPage: FrameworkElement, IChildrenContainer
	{
		public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
		IList<ISharpProp> IChildrenContainer.Children => Children;
		public ReactParam<System.Object>? PrintTicket { get; set; }
		public ReactParam<System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<System.Windows.Rect>? ContentBox { get; set; }
		public ReactParam<System.Windows.Rect>? BleedBox { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FixedPage<FixedPage>();
		}
	}
}
