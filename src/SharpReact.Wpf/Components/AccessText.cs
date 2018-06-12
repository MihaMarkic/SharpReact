using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class AccessText<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.AccessText
		where TElement : global::System.Windows.Controls.AccessText, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Text.HasValue)
			{
				Element.Text = nextProps.Text.Value.Value;
			}
			if (nextProps.FontFamily.HasValue)
			{
				Element.FontFamily = nextProps.FontFamily.Value.Value;
			}
			if (nextProps.FontStyle.HasValue)
			{
				Element.FontStyle = nextProps.FontStyle.Value.Value;
			}
			if (nextProps.FontWeight.HasValue)
			{
				Element.FontWeight = nextProps.FontWeight.Value.Value;
			}
			if (nextProps.FontStretch.HasValue)
			{
				Element.FontStretch = nextProps.FontStretch.Value.Value;
			}
			if (nextProps.FontSize.HasValue)
			{
				Element.FontSize = nextProps.FontSize.Value.Value;
			}
			if (nextProps.Foreground.HasValue)
			{
				Element.Foreground = nextProps.Foreground.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.TextDecorations.HasValue)
			{
				Element.TextDecorations = nextProps.TextDecorations.Value.Value;
			}
			if (nextProps.TextEffects.HasValue)
			{
				Element.TextEffects = nextProps.TextEffects.Value.Value;
			}
			if (nextProps.LineHeight.HasValue)
			{
				Element.LineHeight = nextProps.LineHeight.Value.Value;
			}
			if (nextProps.LineStackingStrategy.HasValue)
			{
				Element.LineStackingStrategy = nextProps.LineStackingStrategy.Value.Value;
			}
			if (nextProps.TextAlignment.HasValue)
			{
				Element.TextAlignment = nextProps.TextAlignment.Value.Value;
			}
			if (nextProps.TextTrimming.HasValue)
			{
				Element.TextTrimming = nextProps.TextTrimming.Value.Value;
			}
			if (nextProps.TextWrapping.HasValue)
			{
				Element.TextWrapping = nextProps.TextWrapping.Value.Value;
			}
			if (nextProps.BaselineOffset.HasValue)
			{
				Element.BaselineOffset = nextProps.BaselineOffset.Value.Value;
			}
		}
	}
}
