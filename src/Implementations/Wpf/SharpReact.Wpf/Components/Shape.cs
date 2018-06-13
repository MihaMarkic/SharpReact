using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class Shape<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Shape
		where TElement : global::System.Windows.Shapes.Shape, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Stretch.HasValue)
			{
				Element.Stretch = nextProps.Stretch.Value.Value;
			}
			if (nextProps.Fill.HasValue)
			{
				Element.Fill = nextProps.Fill.Value.Value;
			}
			if (nextProps.Stroke.HasValue)
			{
				Element.Stroke = nextProps.Stroke.Value.Value;
			}
			if (nextProps.StrokeThickness.HasValue)
			{
				Element.StrokeThickness = nextProps.StrokeThickness.Value.Value;
			}
			if (nextProps.StrokeStartLineCap.HasValue)
			{
				Element.StrokeStartLineCap = nextProps.StrokeStartLineCap.Value.Value;
			}
			if (nextProps.StrokeEndLineCap.HasValue)
			{
				Element.StrokeEndLineCap = nextProps.StrokeEndLineCap.Value.Value;
			}
			if (nextProps.StrokeDashCap.HasValue)
			{
				Element.StrokeDashCap = nextProps.StrokeDashCap.Value.Value;
			}
			if (nextProps.StrokeLineJoin.HasValue)
			{
				Element.StrokeLineJoin = nextProps.StrokeLineJoin.Value.Value;
			}
			if (nextProps.StrokeMiterLimit.HasValue)
			{
				Element.StrokeMiterLimit = nextProps.StrokeMiterLimit.Value.Value;
			}
			if (nextProps.StrokeDashOffset.HasValue)
			{
				Element.StrokeDashOffset = nextProps.StrokeDashOffset.Value.Value;
			}
			if (nextProps.StrokeDashArray.HasValue)
			{
				Element.StrokeDashArray = nextProps.StrokeDashArray.Value.Value;
			}
		}
	}
}
