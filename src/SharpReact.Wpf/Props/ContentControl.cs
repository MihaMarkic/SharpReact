using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class ContentControl: Control, IContainer
	{
		public ISharpProp Content { get; set; }
		public ReactParam<System.Windows.DataTemplate>? ContentTemplate { get; set; }
		public ReactParam<System.Windows.Controls.DataTemplateSelector>? ContentTemplateSelector { get; set; }
		public ReactParam<System.String>? ContentStringFormat { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ContentControl<ContentControl, System.Windows.Controls.ContentControl>();
		}
	}
}
