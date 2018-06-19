using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AbsListView<TProps, TElement>: AdapterView<global::Android.Widget.IListAdapter, TProps, TElement>
		where TProps : Props.AbsListView
		where TElement : global::Android.Widget.AbsListView
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAbsListViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignAbsListViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAbsListViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAbsListViewWithInstanceProperties(element, null, props);
		}
		static void UpdateAbsListViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.CacheColorHint.HasValue)
			{
				element.CacheColorHint = nextProps.CacheColorHint.Value.Value;
			}
			if (nextProps.ChoiceMode.HasValue)
			{
				element.ChoiceMode = nextProps.ChoiceMode.Value.Value;
			}
			if (nextProps.FastScrollAlwaysVisible.HasValue)
			{
				element.FastScrollAlwaysVisible = nextProps.FastScrollAlwaysVisible.Value.Value;
			}
			if (nextProps.FastScrollEnabled.HasValue)
			{
				element.FastScrollEnabled = nextProps.FastScrollEnabled.Value.Value;
			}
			if (nextProps.ScrollingCacheEnabled.HasValue)
			{
				element.ScrollingCacheEnabled = nextProps.ScrollingCacheEnabled.Value.Value;
			}
			if (nextProps.Selector.HasValue)
			{
				element.Selector = nextProps.Selector.Value.Value;
			}
			if (nextProps.SmoothScrollbarEnabled.HasValue)
			{
				element.SmoothScrollbarEnabled = nextProps.SmoothScrollbarEnabled.Value.Value;
			}
			if (nextProps.StackFromBottom.HasValue)
			{
				element.StackFromBottom = nextProps.StackFromBottom.Value.Value;
			}
			if (nextProps.TextFilterEnabled.HasValue)
			{
				element.TextFilterEnabled = nextProps.TextFilterEnabled.Value.Value;
			}
			if (nextProps.TranscriptMode.HasValue)
			{
				element.TranscriptMode = nextProps.TranscriptMode.Value.Value;
			}
			if (!(previous?.Scroll is null) && nextProps.Scroll is null)
			{
				element.Scroll -= nextProps.Scroll;
			}
			if (previous?.Scroll is null && !(nextProps.Scroll is null))
			{
				element.Scroll += nextProps.Scroll;
			}
			if (!(previous?.ScrollStateChanged is null) && nextProps.ScrollStateChanged is null)
			{
				element.ScrollStateChanged -= nextProps.ScrollStateChanged;
			}
			if (previous?.ScrollStateChanged is null && !(nextProps.ScrollStateChanged is null))
			{
				element.ScrollStateChanged += nextProps.ScrollStateChanged;
			}
			if (!(previous?.Recycler is null) && nextProps.Recycler is null)
			{
				element.Recycler -= nextProps.Recycler;
			}
			if (previous?.Recycler is null && !(nextProps.Recycler is null))
			{
				element.Recycler += nextProps.Recycler;
			}
		}
	}
}
