using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class TextBlock: FrameworkElement
	{
		public ReactParam<global::System.Double>? BaselineOffset { get; set; }
		public ReactParam<global::System.String>? Text { get; set; }
		public ReactParam<global::System.Windows.Media.FontFamily>? FontFamily { get; set; }
		public ReactParam<global::System.Windows.FontStyle>? FontStyle { get; set; }
		public ReactParam<global::System.Windows.FontWeight>? FontWeight { get; set; }
		public ReactParam<global::System.Windows.FontStretch>? FontStretch { get; set; }
		public ReactParam<global::System.Double>? FontSize { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? Foreground { get; set; }
		public ReactParam<global::System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<global::System.Windows.TextDecorationCollection>? TextDecorations { get; set; }
		public ReactParam<global::System.Windows.Media.TextEffectCollection>? TextEffects { get; set; }
		public ReactParam<global::System.Double>? LineHeight { get; set; }
		public ReactParam<global::System.Windows.LineStackingStrategy>? LineStackingStrategy { get; set; }
		public ReactParam<global::System.Windows.Thickness>? Padding { get; set; }
		public ReactParam<global::System.Windows.TextAlignment>? TextAlignment { get; set; }
		public ReactParam<global::System.Windows.TextTrimming>? TextTrimming { get; set; }
		public ReactParam<global::System.Windows.TextWrapping>? TextWrapping { get; set; }
		public ReactParam<global::System.Boolean>? IsHyphenationEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TextBlock<TextBlock, System.Windows.Controls.TextBlock>();
		}
	}
}
