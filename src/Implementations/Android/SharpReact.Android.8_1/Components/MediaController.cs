using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class MediaController<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.MediaController
		where TElement : global::Android.Widget.MediaController
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.NextClick, null) && ReferenceEquals(nextProps.NextClick, null))
			{
				Element.NextClick -= nextProps.NextClick;
			}
			if (ReferenceEquals(previous?.NextClick, null) && !ReferenceEquals(nextProps.NextClick, null))
			{
				Element.NextClick += nextProps.NextClick;
			}
			if (!ReferenceEquals(previous?.PreviousClick, null) && ReferenceEquals(nextProps.PreviousClick, null))
			{
				Element.PreviousClick -= nextProps.PreviousClick;
			}
			if (ReferenceEquals(previous?.PreviousClick, null) && !ReferenceEquals(nextProps.PreviousClick, null))
			{
				Element.PreviousClick += nextProps.PreviousClick;
			}
		}
	}
}
