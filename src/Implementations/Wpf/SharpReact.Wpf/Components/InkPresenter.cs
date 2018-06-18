using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class InkPresenter<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.InkPresenter
		where TElement : global::System.Windows.Controls.InkPresenter, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Strokes.HasValue)
			{
				Element.Strokes = nextProps.Strokes.Value.Value;
			}
		}
	}
}
