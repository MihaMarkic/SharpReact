using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class AutoCompleteTextView<TProps, TElement>: EditText<TProps, TElement>
		where TProps : Props.AutoCompleteTextView
		where TElement : global::Android.Widget.AutoCompleteTextView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.AutoCompleteTextView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateAutoCompleteTextViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignAutoCompleteTextViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignAutoCompleteTextViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateAutoCompleteTextViewWithInstanceProperties(element, null, props);
		}
		static void UpdateAutoCompleteTextViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Adapter.HasValue)
			{
				element.Adapter = nextProps.Adapter.Value.Value;
			}
			if (nextProps.DropDownAnchor.HasValue)
			{
				element.DropDownAnchor = nextProps.DropDownAnchor.Value.Value;
			}
			if (nextProps.DropDownHeight.HasValue)
			{
				element.DropDownHeight = nextProps.DropDownHeight.Value.Value;
			}
			if (nextProps.DropDownHorizontalOffset.HasValue)
			{
				element.DropDownHorizontalOffset = nextProps.DropDownHorizontalOffset.Value.Value;
			}
			if (nextProps.DropDownVerticalOffset.HasValue)
			{
				element.DropDownVerticalOffset = nextProps.DropDownVerticalOffset.Value.Value;
			}
			if (nextProps.DropDownWidth.HasValue)
			{
				element.DropDownWidth = nextProps.DropDownWidth.Value.Value;
			}
			if (nextProps.ListSelection.HasValue)
			{
				element.ListSelection = nextProps.ListSelection.Value.Value;
			}
			if (nextProps.OnItemClickListener.HasValue)
			{
				element.OnItemClickListener = nextProps.OnItemClickListener.Value.Value;
			}
			if (nextProps.OnItemSelectedListener.HasValue)
			{
				element.OnItemSelectedListener = nextProps.OnItemSelectedListener.Value.Value;
			}
			if (nextProps.Threshold.HasValue)
			{
				element.Threshold = nextProps.Threshold.Value.Value;
			}
			if (nextProps.Validator.HasValue)
			{
				element.Validator = nextProps.Validator.Value.Value;
			}
			if (!(previous?.Dismiss is null) && nextProps.Dismiss is null)
			{
				element.Dismiss -= nextProps.Dismiss;
			}
			if (previous?.Dismiss is null && !(nextProps.Dismiss is null))
			{
				element.Dismiss += nextProps.Dismiss;
			}
			if (!(previous?.ItemClick is null) && nextProps.ItemClick is null)
			{
				element.ItemClick -= nextProps.ItemClick;
			}
			if (previous?.ItemClick is null && !(nextProps.ItemClick is null))
			{
				element.ItemClick += nextProps.ItemClick;
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
