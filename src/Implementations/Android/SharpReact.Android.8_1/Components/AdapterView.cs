using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public abstract partial class AdapterView<TProps, TElement>: ViewGroup<TProps, TElement>
		where TProps : Props.AdapterView
		where TElement : global::Android.Widget.AdapterView
	{
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAdapterViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignAdapterViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAdapterViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAdapterViewWithInstanceProperties(element, null, props);
		}
		static void UpdateAdapterViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.EmptyView.HasValue)
			{
				element.EmptyView = nextProps.EmptyView.Value.Value;
			}
			if (nextProps.OnItemClickListener.HasValue)
			{
				element.OnItemClickListener = nextProps.OnItemClickListener.Value.Value;
			}
			if (nextProps.OnItemLongClickListener.HasValue)
			{
				element.OnItemLongClickListener = nextProps.OnItemLongClickListener.Value.Value;
			}
			if (nextProps.OnItemSelectedListener.HasValue)
			{
				element.OnItemSelectedListener = nextProps.OnItemSelectedListener.Value.Value;
			}
			if (!(previous?.ItemClick is null) && nextProps.ItemClick is null)
			{
				element.ItemClick -= nextProps.ItemClick;
			}
			if (previous?.ItemClick is null && !(nextProps.ItemClick is null))
			{
				element.ItemClick += nextProps.ItemClick;
			}
			if (!(previous?.ItemLongClick is null) && nextProps.ItemLongClick is null)
			{
				element.ItemLongClick -= nextProps.ItemLongClick;
			}
			if (previous?.ItemLongClick is null && !(nextProps.ItemLongClick is null))
			{
				element.ItemLongClick += nextProps.ItemLongClick;
			}
			if (!(previous?.ItemSelected is null) && nextProps.ItemSelected is null)
			{
				element.ItemSelected -= nextProps.ItemSelected;
			}
			if (previous?.ItemSelected is null && !(nextProps.ItemSelected is null))
			{
				element.ItemSelected += nextProps.ItemSelected;
			}
			if (!(previous?.NothingSelected is null) && nextProps.NothingSelected is null)
			{
				element.NothingSelected -= nextProps.NothingSelected;
			}
			if (previous?.NothingSelected is null && !(nextProps.NothingSelected is null))
			{
				element.NothingSelected += nextProps.NothingSelected;
			}
		}
	}
}
