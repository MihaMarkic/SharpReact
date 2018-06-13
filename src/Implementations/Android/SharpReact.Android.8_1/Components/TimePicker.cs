using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class TimePicker<TProps, TElement>: FrameLayout<TProps, TElement>
		where TProps : Props.TimePicker
		where TElement : global::Android.Widget.TimePicker
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.TimePicker(context);
		}
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Hour.HasValue)
			{
				Element.Hour = nextProps.Hour.Value.Value;
			}
			if (nextProps.Minute.HasValue)
			{
				Element.Minute = nextProps.Minute.Value.Value;
			}
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Views, nextProps.Views, nameof(SharpReact.Android.Props.TimePicker.Views), nameof(SharpReact.Android.Props.TimePicker));
				ElementSynchronizer.SyncElements(Element, elements);
			}
			if (!ReferenceEquals(previous?.TimeChanged, null) && ReferenceEquals(nextProps.TimeChanged, null))
			{
				Element.TimeChanged -= nextProps.TimeChanged;
			}
			if (ReferenceEquals(previous?.TimeChanged, null) && !ReferenceEquals(nextProps.TimeChanged, null))
			{
				Element.TimeChanged += nextProps.TimeChanged;
			}
		}
	}
}
