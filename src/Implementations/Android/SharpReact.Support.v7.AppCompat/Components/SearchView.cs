using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Components;

namespace SharpReact.Support.v7.AppCompat.Components
{
	public  partial class SearchView<TProps, TElement>: LinearLayoutCompat<TProps, TElement>
		where TProps : Props.SearchView
		where TElement : global::Android.Support.V7.Widget.SearchView
	{
		public override void CreateElement(global::Android.Content.Context context)
		{
			Element = (TElement)new global::Android.Support.V7.Widget.SearchView(context);
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
			if (nextProps.ImeOptions.HasValue)
			{
				element.ImeOptions = nextProps.ImeOptions.Value.Value;
			}
			if (nextProps.InputType.HasValue)
			{
				element.InputType = nextProps.InputType.Value.Value;
			}
			if (nextProps.MaxWidth.HasValue)
			{
				element.MaxWidth = nextProps.MaxWidth.Value.Value;
			}
			if (nextProps.QueryHintFormatted.HasValue)
			{
				element.QueryHintFormatted = nextProps.QueryHintFormatted.Value.Value;
			}
			if (nextProps.QueryHint.HasValue)
			{
				element.QueryHint = nextProps.QueryHint.Value.Value;
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
