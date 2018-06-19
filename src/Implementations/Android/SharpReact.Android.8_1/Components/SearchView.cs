using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Components
{
	public  partial class SearchView<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.SearchView
		where TElement : global::Android.Widget.SearchView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Widget.SearchView(context);
			InitElement(Element);
		}
		partial void InitElement(TElement element);
		public override void AssignProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			UpdateSearchViewWithInstanceProperties(Element, previous, nextProps);
			PostAssignSearchViewProperties(renderer, level, newState, previous, nextProps);
		}
		partial void PostAssignSearchViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps);
		protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
		{
			base.UpdateElement(renderer, element, props);
			UpdateSearchViewWithInstanceProperties(element, null, props);
		}
		static void UpdateSearchViewWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
		{
			if (nextProps.Iconified.HasValue)
			{
				element.Iconified = nextProps.Iconified.Value.Value;
			}
			if (nextProps.QueryRefinementEnabled.HasValue)
			{
				element.QueryRefinementEnabled = nextProps.QueryRefinementEnabled.Value.Value;
			}
			if (nextProps.SubmitButtonEnabled.HasValue)
			{
				element.SubmitButtonEnabled = nextProps.SubmitButtonEnabled.Value.Value;
			}
			if (nextProps.SuggestionsAdapter.HasValue)
			{
				element.SuggestionsAdapter = nextProps.SuggestionsAdapter.Value.Value;
			}
			if (!(previous?.Close is null) && nextProps.Close is null)
			{
				element.Close -= nextProps.Close;
			}
			if (previous?.Close is null && !(nextProps.Close is null))
			{
				element.Close += nextProps.Close;
			}
			if (!(previous?.QueryTextFocusChange is null) && nextProps.QueryTextFocusChange is null)
			{
				element.QueryTextFocusChange -= nextProps.QueryTextFocusChange;
			}
			if (previous?.QueryTextFocusChange is null && !(nextProps.QueryTextFocusChange is null))
			{
				element.QueryTextFocusChange += nextProps.QueryTextFocusChange;
			}
			if (!(previous?.QueryTextChange is null) && nextProps.QueryTextChange is null)
			{
				element.QueryTextChange -= nextProps.QueryTextChange;
			}
			if (previous?.QueryTextChange is null && !(nextProps.QueryTextChange is null))
			{
				element.QueryTextChange += nextProps.QueryTextChange;
			}
			if (!(previous?.QueryTextSubmit is null) && nextProps.QueryTextSubmit is null)
			{
				element.QueryTextSubmit -= nextProps.QueryTextSubmit;
			}
			if (previous?.QueryTextSubmit is null && !(nextProps.QueryTextSubmit is null))
			{
				element.QueryTextSubmit += nextProps.QueryTextSubmit;
			}
			if (!(previous?.SearchClick is null) && nextProps.SearchClick is null)
			{
				element.SearchClick -= nextProps.SearchClick;
			}
			if (previous?.SearchClick is null && !(nextProps.SearchClick is null))
			{
				element.SearchClick += nextProps.SearchClick;
			}
			if (!(previous?.SuggestionClick is null) && nextProps.SuggestionClick is null)
			{
				element.SuggestionClick -= nextProps.SuggestionClick;
			}
			if (previous?.SuggestionClick is null && !(nextProps.SuggestionClick is null))
			{
				element.SuggestionClick += nextProps.SuggestionClick;
			}
			if (!(previous?.SuggestionSelect is null) && nextProps.SuggestionSelect is null)
			{
				element.SuggestionSelect -= nextProps.SuggestionSelect;
			}
			if (previous?.SuggestionSelect is null && !(nextProps.SuggestionSelect is null))
			{
				element.SuggestionSelect += nextProps.SuggestionSelect;
			}
		}
	}
}
