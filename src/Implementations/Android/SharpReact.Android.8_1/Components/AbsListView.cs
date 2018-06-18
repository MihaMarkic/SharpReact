using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AbsListView<TProps, TElement>: AdapterView<global::Android.Widget.IListAdapter, TProps, TElement>
		where TProps : Props.AbsListView
		where TElement : global::Android.Widget.AbsListView
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.CacheColorHint.HasValue)
			{
				Element.CacheColorHint = nextProps.CacheColorHint.Value.Value;
			}
			if (nextProps.ChoiceMode.HasValue)
			{
				Element.ChoiceMode = nextProps.ChoiceMode.Value.Value;
			}
			if (nextProps.FastScrollAlwaysVisible.HasValue)
			{
				Element.FastScrollAlwaysVisible = nextProps.FastScrollAlwaysVisible.Value.Value;
			}
			if (nextProps.FastScrollEnabled.HasValue)
			{
				Element.FastScrollEnabled = nextProps.FastScrollEnabled.Value.Value;
			}
			if (nextProps.ScrollingCacheEnabled.HasValue)
			{
				Element.ScrollingCacheEnabled = nextProps.ScrollingCacheEnabled.Value.Value;
			}
			if (nextProps.Selector.HasValue)
			{
				Element.Selector = nextProps.Selector.Value.Value;
			}
			if (nextProps.SmoothScrollbarEnabled.HasValue)
			{
				Element.SmoothScrollbarEnabled = nextProps.SmoothScrollbarEnabled.Value.Value;
			}
			if (nextProps.StackFromBottom.HasValue)
			{
				Element.StackFromBottom = nextProps.StackFromBottom.Value.Value;
			}
			if (nextProps.TextFilterEnabled.HasValue)
			{
				Element.TextFilterEnabled = nextProps.TextFilterEnabled.Value.Value;
			}
			if (nextProps.TranscriptMode.HasValue)
			{
				Element.TranscriptMode = nextProps.TranscriptMode.Value.Value;
			}
			if (!ReferenceEquals(previous?.Scroll, null) && ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll -= nextProps.Scroll;
			}
			if (ReferenceEquals(previous?.Scroll, null) && !ReferenceEquals(nextProps.Scroll, null))
			{
				Element.Scroll += nextProps.Scroll;
			}
			if (!ReferenceEquals(previous?.ScrollStateChanged, null) && ReferenceEquals(nextProps.ScrollStateChanged, null))
			{
				Element.ScrollStateChanged -= nextProps.ScrollStateChanged;
			}
			if (ReferenceEquals(previous?.ScrollStateChanged, null) && !ReferenceEquals(nextProps.ScrollStateChanged, null))
			{
				Element.ScrollStateChanged += nextProps.ScrollStateChanged;
			}
			if (!ReferenceEquals(previous?.Recycler, null) && ReferenceEquals(nextProps.Recycler, null))
			{
				Element.Recycler -= nextProps.Recycler;
			}
			if (ReferenceEquals(previous?.Recycler, null) && !ReferenceEquals(nextProps.Recycler, null))
			{
				Element.Recycler += nextProps.Recycler;
			}
		}
	}
}
