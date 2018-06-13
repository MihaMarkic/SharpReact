using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ScrollContentPresenter: ContentPresenter
	{
		public ReactParam<global::System.Boolean>? CanContentScroll { get; set; }
		public ReactParam<global::System.Boolean>? CanHorizontallyScroll { get; set; }
		public ReactParam<global::System.Boolean>? CanVerticallyScroll { get; set; }
		public ReactParam<global::System.Windows.Controls.ScrollViewer>? ScrollOwner { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ScrollContentPresenter<ScrollContentPresenter>();
		}
	}
}
