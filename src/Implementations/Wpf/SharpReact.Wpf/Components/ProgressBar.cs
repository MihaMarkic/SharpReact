using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class ProgressBar<TProps, TElement>: RangeBase<TProps, TElement>
		where TProps : Props.ProgressBar
		where TElement : global::System.Windows.Controls.ProgressBar, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.IsIndeterminate.HasValue)
			{
				Element.IsIndeterminate = nextProps.IsIndeterminate.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
		}
	}
}
