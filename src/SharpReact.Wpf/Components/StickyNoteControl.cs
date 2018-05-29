
namespace SharpReact.Wpf.Components
{
	public abstract class StickyNoteControl<TProps>: Control<TProps, System.Windows.Controls.StickyNoteControl>
		where TProps : Props.StickyNoteControl
	{
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsExpanded.HasValue)
			{
				Element.IsExpanded = nextProps.IsExpanded.Value.Value;
			}
			if (nextProps.CaptionFontFamily.HasValue)
			{
				Element.CaptionFontFamily = nextProps.CaptionFontFamily.Value.Value;
			}
			if (nextProps.CaptionFontSize.HasValue)
			{
				Element.CaptionFontSize = nextProps.CaptionFontSize.Value.Value;
			}
			if (nextProps.CaptionFontStretch.HasValue)
			{
				Element.CaptionFontStretch = nextProps.CaptionFontStretch.Value.Value;
			}
			if (nextProps.CaptionFontStyle.HasValue)
			{
				Element.CaptionFontStyle = nextProps.CaptionFontStyle.Value.Value;
			}
			if (nextProps.CaptionFontWeight.HasValue)
			{
				Element.CaptionFontWeight = nextProps.CaptionFontWeight.Value.Value;
			}
			if (nextProps.PenWidth.HasValue)
			{
				Element.PenWidth = nextProps.PenWidth.Value.Value;
			}
		}
	}
}
