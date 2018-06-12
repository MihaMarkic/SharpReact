using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class PageContent: FrameworkElement
	{
		public ReactParam<global::System.Uri>? Source { get; set; }
		public ReactParam<global::System.Windows.Documents.FixedPage>? Child { get; set; }
		public System.Windows.Documents.GetPageRootCompletedEventHandler GetPageRootCompleted { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.PageContent<PageContent>();
		}
	}
}
