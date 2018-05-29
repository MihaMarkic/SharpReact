using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public abstract class StickyNoteControl: Control
	{
		public ReactParam<System.Boolean>? IsExpanded { get; set; }
		public ReactParam<System.Windows.Media.FontFamily>? CaptionFontFamily { get; set; }
		public ReactParam<System.Double>? CaptionFontSize { get; set; }
		public ReactParam<System.Windows.FontStretch>? CaptionFontStretch { get; set; }
		public ReactParam<System.Windows.FontStyle>? CaptionFontStyle { get; set; }
		public ReactParam<System.Windows.FontWeight>? CaptionFontWeight { get; set; }
		public ReactParam<System.Double>? PenWidth { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			throw new System.NotImplementedException();
		}
	}
}
