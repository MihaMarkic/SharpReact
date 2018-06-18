using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Viewport3D<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Viewport3D
		where TElement : global::System.Windows.Controls.Viewport3D, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Camera.HasValue)
			{
				Element.Camera = nextProps.Camera.Value.Value;
			}
		}
	}
}
