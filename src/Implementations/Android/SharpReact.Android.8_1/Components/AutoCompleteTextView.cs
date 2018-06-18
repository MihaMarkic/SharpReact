using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public  class AutoCompleteTextView<TProps, TElement>: EditText<TProps, TElement>
		where TProps : Props.AutoCompleteTextView
		where TElement : global::Android.Widget.AutoCompleteTextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AutoCompleteTextView(context);
		}
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Adapter.HasValue)
			{
				Element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.DropDownAnchor.HasValue)
			{
				Element.DropDownAnchor = nextProps.DropDownAnchor.Value.Value;
			}
			if (nextProps.DropDownHeight.HasValue)
			{
				Element.DropDownHeight = nextProps.DropDownHeight.Value.Value;
			}
			if (nextProps.DropDownHorizontalOffset.HasValue)
			{
				Element.DropDownHorizontalOffset = nextProps.DropDownHorizontalOffset.Value.Value;
			}
			if (nextProps.DropDownVerticalOffset.HasValue)
			{
				Element.DropDownVerticalOffset = nextProps.DropDownVerticalOffset.Value.Value;
			}
			if (nextProps.DropDownWidth.HasValue)
			{
				Element.DropDownWidth = nextProps.DropDownWidth.Value.Value;
			}
			if (nextProps.ListSelection.HasValue)
			{
				Element.ListSelection = nextProps.ListSelection.Value.Value;
			}
			if (nextProps.OnItemClickListener.HasValue)
			{
				Element.OnItemClickListener = nextProps.OnItemClickListener.Value.Value;
			}
			if (nextProps.OnItemSelectedListener.HasValue)
			{
				Element.OnItemSelectedListener = nextProps.OnItemSelectedListener.Value.Value;
			}
			if (nextProps.Threshold.HasValue)
			{
				Element.Threshold = nextProps.Threshold.Value.Value;
			}
			if (nextProps.Validator.HasValue)
			{
				Element.Validator = nextProps.Validator.Value.Value;
			}
			if (!ReferenceEquals(previous?.Dismiss, null) && ReferenceEquals(nextProps.Dismiss, null))
			{
				Element.Dismiss -= nextProps.Dismiss;
			}
			if (ReferenceEquals(previous?.Dismiss, null) && !ReferenceEquals(nextProps.Dismiss, null))
			{
				Element.Dismiss += nextProps.Dismiss;
			}
			if (!ReferenceEquals(previous?.ItemClick, null) && ReferenceEquals(nextProps.ItemClick, null))
			{
				Element.ItemClick -= nextProps.ItemClick;
			}
			if (ReferenceEquals(previous?.ItemClick, null) && !ReferenceEquals(nextProps.ItemClick, null))
			{
				Element.ItemClick += nextProps.ItemClick;
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
