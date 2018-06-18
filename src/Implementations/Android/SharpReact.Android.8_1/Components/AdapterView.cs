using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class AdapterView<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AdapterView
		where TElement : global::Android.Widget.AdapterView
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.EmptyView.HasValue)
			{
				Element.EmptyView = nextProps.EmptyView.Value.Value;
			}
			if (nextProps.OnItemClickListener.HasValue)
			{
				Element.OnItemClickListener = nextProps.OnItemClickListener.Value.Value;
			}
			if (nextProps.OnItemLongClickListener.HasValue)
			{
				Element.OnItemLongClickListener = nextProps.OnItemLongClickListener.Value.Value;
			}
			if (nextProps.OnItemSelectedListener.HasValue)
			{
				Element.OnItemSelectedListener = nextProps.OnItemSelectedListener.Value.Value;
			}
			if (!ReferenceEquals(previous?.ItemClick, null) && ReferenceEquals(nextProps.ItemClick, null))
			{
				Element.ItemClick -= nextProps.ItemClick;
			}
			if (ReferenceEquals(previous?.ItemClick, null) && !ReferenceEquals(nextProps.ItemClick, null))
			{
				Element.ItemClick += nextProps.ItemClick;
			}
			if (!ReferenceEquals(previous?.ItemLongClick, null) && ReferenceEquals(nextProps.ItemLongClick, null))
			{
				Element.ItemLongClick -= nextProps.ItemLongClick;
			}
			if (ReferenceEquals(previous?.ItemLongClick, null) && !ReferenceEquals(nextProps.ItemLongClick, null))
			{
				Element.ItemLongClick += nextProps.ItemLongClick;
			}
			if (!ReferenceEquals(previous?.ItemSelected, null) && ReferenceEquals(nextProps.ItemSelected, null))
			{
				Element.ItemSelected -= nextProps.ItemSelected;
			}
			if (ReferenceEquals(previous?.ItemSelected, null) && !ReferenceEquals(nextProps.ItemSelected, null))
			{
				Element.ItemSelected += nextProps.ItemSelected;
			}
			if (!ReferenceEquals(previous?.NothingSelected, null) && ReferenceEquals(nextProps.NothingSelected, null))
			{
				Element.NothingSelected -= nextProps.NothingSelected;
			}
			if (ReferenceEquals(previous?.NothingSelected, null) && !ReferenceEquals(nextProps.NothingSelected, null))
			{
				Element.NothingSelected += nextProps.NothingSelected;
			}
		}
	}
}
