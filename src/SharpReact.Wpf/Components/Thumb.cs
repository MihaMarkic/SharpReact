
namespace SharpReact.Wpf.Components
{
	public  class Thumb<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.Thumb
		where TElement : System.Windows.Controls.Primitives.Thumb
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.Thumb();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (!ReferenceEquals(Props?.DragStarted, null) && ReferenceEquals(nextProps.DragStarted, null))
			{
				Element.DragStarted -= nextProps.DragStarted;
			}
			if (ReferenceEquals(Props?.DragStarted, null) && !ReferenceEquals(nextProps.DragStarted, null))
			{
				Element.DragStarted += nextProps.DragStarted;
			}
			if (!ReferenceEquals(Props?.DragDelta, null) && ReferenceEquals(nextProps.DragDelta, null))
			{
				Element.DragDelta -= nextProps.DragDelta;
			}
			if (ReferenceEquals(Props?.DragDelta, null) && !ReferenceEquals(nextProps.DragDelta, null))
			{
				Element.DragDelta += nextProps.DragDelta;
			}
			if (!ReferenceEquals(Props?.DragCompleted, null) && ReferenceEquals(nextProps.DragCompleted, null))
			{
				Element.DragCompleted -= nextProps.DragCompleted;
			}
			if (ReferenceEquals(Props?.DragCompleted, null) && !ReferenceEquals(nextProps.DragCompleted, null))
			{
				Element.DragCompleted += nextProps.DragCompleted;
			}
		}
	}
}
