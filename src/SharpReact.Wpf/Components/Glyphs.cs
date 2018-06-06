using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Glyphs<TProps>: FrameworkElement<TProps, System.Windows.Documents.Glyphs>
		where TProps : Props.Glyphs
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Fill.HasValue)
			{
				Element.Fill = nextProps.Fill.Value.Value;
			}
			if (nextProps.Indices.HasValue)
			{
				Element.Indices = nextProps.Indices.Value.Value;
			}
			if (nextProps.UnicodeString.HasValue)
			{
				Element.UnicodeString = nextProps.UnicodeString.Value.Value;
			}
			if (nextProps.CaretStops.HasValue)
			{
				Element.CaretStops = nextProps.CaretStops.Value.Value;
			}
			if (nextProps.FontRenderingEmSize.HasValue)
			{
				Element.FontRenderingEmSize = nextProps.FontRenderingEmSize.Value.Value;
			}
			if (nextProps.OriginX.HasValue)
			{
				Element.OriginX = nextProps.OriginX.Value.Value;
			}
			if (nextProps.OriginY.HasValue)
			{
				Element.OriginY = nextProps.OriginY.Value.Value;
			}
			if (nextProps.FontUri.HasValue)
			{
				Element.FontUri = nextProps.FontUri.Value.Value;
			}
			if (nextProps.StyleSimulations.HasValue)
			{
				Element.StyleSimulations = nextProps.StyleSimulations.Value.Value;
			}
			if (nextProps.IsSideways.HasValue)
			{
				Element.IsSideways = nextProps.IsSideways.Value.Value;
			}
			if (nextProps.BidiLevel.HasValue)
			{
				Element.BidiLevel = nextProps.BidiLevel.Value.Value;
			}
			if (nextProps.DeviceFontName.HasValue)
			{
				Element.DeviceFontName = nextProps.DeviceFontName.Value.Value;
			}
		}
	}
}
