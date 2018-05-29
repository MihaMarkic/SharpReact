using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ScrollContentPresenter: ContentPresenter
	{
		public ReactParam<System.Boolean>? CanContentScroll { get; set; }
		public ReactParam<System.Boolean>? CanHorizontallyScroll { get; set; }
		public ReactParam<System.Boolean>? CanVerticallyScroll { get; set; }
		public ReactParam<System.Windows.Controls.ScrollViewer>? ScrollOwner { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ScrollContentPresenter<ScrollContentPresenter>();
		}
	}
}
