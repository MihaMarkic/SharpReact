using SharpReact.Core;

namespace SharpReact.Android.Components
{
	public abstract class SearchView<TProps, TElement>: LinearLayout<TProps, TElement>
		where TProps : Props.SearchView
		where TElement : global::Android.Widget.SearchView
	{
		public override void AssignProperties(ISharpCreator<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Iconified.HasValue)
			{
				Element.Iconified = nextProps.Iconified.Value.Value;
			}
			if (nextProps.QueryRefinementEnabled.HasValue)
			{
				Element.QueryRefinementEnabled = nextProps.QueryRefinementEnabled.Value.Value;
			}
			if (nextProps.SubmitButtonEnabled.HasValue)
			{
				Element.SubmitButtonEnabled = nextProps.SubmitButtonEnabled.Value.Value;
			}
			if (nextProps.SuggestionsAdapter.HasValue)
			{
				Element.SuggestionsAdapter = nextProps.SuggestionsAdapter.Value.Value;
			}
			if (!ReferenceEquals(previous?.Close, null) && ReferenceEquals(nextProps.Close, null))
			{
				Element.Close -= nextProps.Close;
			}
			if (ReferenceEquals(previous?.Close, null) && !ReferenceEquals(nextProps.Close, null))
			{
				Element.Close += nextProps.Close;
			}
			if (!ReferenceEquals(previous?.QueryTextFocusChange, null) && ReferenceEquals(nextProps.QueryTextFocusChange, null))
			{
				Element.QueryTextFocusChange -= nextProps.QueryTextFocusChange;
			}
			if (ReferenceEquals(previous?.QueryTextFocusChange, null) && !ReferenceEquals(nextProps.QueryTextFocusChange, null))
			{
				Element.QueryTextFocusChange += nextProps.QueryTextFocusChange;
			}
			if (!ReferenceEquals(previous?.QueryTextChange, null) && ReferenceEquals(nextProps.QueryTextChange, null))
			{
				Element.QueryTextChange -= nextProps.QueryTextChange;
			}
			if (ReferenceEquals(previous?.QueryTextChange, null) && !ReferenceEquals(nextProps.QueryTextChange, null))
			{
				Element.QueryTextChange += nextProps.QueryTextChange;
			}
			if (!ReferenceEquals(previous?.QueryTextSubmit, null) && ReferenceEquals(nextProps.QueryTextSubmit, null))
			{
				Element.QueryTextSubmit -= nextProps.QueryTextSubmit;
			}
			if (ReferenceEquals(previous?.QueryTextSubmit, null) && !ReferenceEquals(nextProps.QueryTextSubmit, null))
			{
				Element.QueryTextSubmit += nextProps.QueryTextSubmit;
			}
			if (!ReferenceEquals(previous?.SearchClick, null) && ReferenceEquals(nextProps.SearchClick, null))
			{
				Element.SearchClick -= nextProps.SearchClick;
			}
			if (ReferenceEquals(previous?.SearchClick, null) && !ReferenceEquals(nextProps.SearchClick, null))
			{
				Element.SearchClick += nextProps.SearchClick;
			}
			if (!ReferenceEquals(previous?.SuggestionClick, null) && ReferenceEquals(nextProps.SuggestionClick, null))
			{
				Element.SuggestionClick -= nextProps.SuggestionClick;
			}
			if (ReferenceEquals(previous?.SuggestionClick, null) && !ReferenceEquals(nextProps.SuggestionClick, null))
			{
				Element.SuggestionClick += nextProps.SuggestionClick;
			}
			if (!ReferenceEquals(previous?.SuggestionSelect, null) && ReferenceEquals(nextProps.SuggestionSelect, null))
			{
				Element.SuggestionSelect -= nextProps.SuggestionSelect;
			}
			if (ReferenceEquals(previous?.SuggestionSelect, null) && !ReferenceEquals(nextProps.SuggestionSelect, null))
			{
				Element.SuggestionSelect += nextProps.SuggestionSelect;
			}
		}
	}
}
