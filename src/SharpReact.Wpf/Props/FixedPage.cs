using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class FixedPage: FrameworkElement
	{
		public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
		public ReactParam<global::System.Object>? PrintTicket { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<global::System.Windows.Rect>? ContentBox { get; set; }
		public ReactParam<global::System.Windows.Rect>? BleedBox { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.FixedPage<FixedPage>();
		}
		protected override void UnmountComponent()
		{
			UnmountComponents(Children);
			base.UnmountComponent();
		}
	}
}
