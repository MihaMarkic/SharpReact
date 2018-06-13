using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ContentPresenter: FrameworkElement
	{
		public ReactParam<global::System.Boolean>? RecognizesAccessKey { get; set; }
		public ISharpProp Content { get; set; }
		public ReactParam<global::System.Windows.DataTemplate>? ContentTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.DataTemplateSelector>? ContentTemplateSelector { get; set; }
		public ReactParam<global::System.String>? ContentStringFormat { get; set; }
		public ReactParam<global::System.String>? ContentSource { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ContentPresenter<ContentPresenter, System.Windows.Controls.ContentPresenter>();
		}
		protected override void UnmountComponent()
		{
			UnmountComponent(Content);
			base.UnmountComponent();
		}
	}
}
