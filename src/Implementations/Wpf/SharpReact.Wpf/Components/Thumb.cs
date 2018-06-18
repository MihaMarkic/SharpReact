using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Thumb<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.Thumb
		where TElement : global::System.Windows.Controls.Primitives.Thumb, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.DragStarted, null) && ReferenceEquals(nextProps.DragStarted, null))
			{
				Element.DragStarted -= nextProps.DragStarted;
			}
			if (ReferenceEquals(previous?.DragStarted, null) && !ReferenceEquals(nextProps.DragStarted, null))
			{
				Element.DragStarted += nextProps.DragStarted;
			}
			if (!ReferenceEquals(previous?.DragDelta, null) && ReferenceEquals(nextProps.DragDelta, null))
			{
				Element.DragDelta -= nextProps.DragDelta;
			}
			if (ReferenceEquals(previous?.DragDelta, null) && !ReferenceEquals(nextProps.DragDelta, null))
			{
				Element.DragDelta += nextProps.DragDelta;
			}
			if (!ReferenceEquals(previous?.DragCompleted, null) && ReferenceEquals(nextProps.DragCompleted, null))
			{
				Element.DragCompleted -= nextProps.DragCompleted;
			}
			if (ReferenceEquals(previous?.DragCompleted, null) && !ReferenceEquals(nextProps.DragCompleted, null))
			{
				Element.DragCompleted += nextProps.DragCompleted;
			}
		}
	}
}
