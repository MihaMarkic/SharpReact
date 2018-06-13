using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class VideoView<TProps, TElement>: SurfaceView<TProps, TElement>
		where TProps : Props.VideoView
		where TElement : global::Android.Widget.VideoView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.VideoView(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (!ReferenceEquals(previous?.Completion, null) && ReferenceEquals(nextProps.Completion, null))
			{
				Element.Completion -= nextProps.Completion;
			}
			if (ReferenceEquals(previous?.Completion, null) && !ReferenceEquals(nextProps.Completion, null))
			{
				Element.Completion += nextProps.Completion;
			}
			if (!ReferenceEquals(previous?.Error, null) && ReferenceEquals(nextProps.Error, null))
			{
				Element.Error -= nextProps.Error;
			}
			if (ReferenceEquals(previous?.Error, null) && !ReferenceEquals(nextProps.Error, null))
			{
				Element.Error += nextProps.Error;
			}
			if (!ReferenceEquals(previous?.Info, null) && ReferenceEquals(nextProps.Info, null))
			{
				Element.Info -= nextProps.Info;
			}
			if (ReferenceEquals(previous?.Info, null) && !ReferenceEquals(nextProps.Info, null))
			{
				Element.Info += nextProps.Info;
			}
			if (!ReferenceEquals(previous?.Prepared, null) && ReferenceEquals(nextProps.Prepared, null))
			{
				Element.Prepared -= nextProps.Prepared;
			}
			if (ReferenceEquals(previous?.Prepared, null) && !ReferenceEquals(nextProps.Prepared, null))
			{
				Element.Prepared += nextProps.Prepared;
			}
		}
	}
}
