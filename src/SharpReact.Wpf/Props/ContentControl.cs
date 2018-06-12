using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ContentControl: Control
	{
		public ISharpProp Content { get; set; }
		public ReactParam<global::System.Windows.DataTemplate>? ContentTemplate { get; set; }
		public ReactParam<global::System.Windows.Controls.DataTemplateSelector>? ContentTemplateSelector { get; set; }
		public ReactParam<global::System.String>? ContentStringFormat { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ContentControl<ContentControl, System.Windows.Controls.ContentControl>();
		}
		protected override void UnmountComponent()
		{
			UnmountComponent(Content);
			base.UnmountComponent();
		}
	}
}
