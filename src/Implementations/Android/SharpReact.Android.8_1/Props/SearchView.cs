using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract class SearchView: LinearLayout
	{
		public ReactParam<global::System.Boolean>? Iconified { get; set; }
		public ReactParam<global::System.Boolean>? QueryRefinementEnabled { get; set; }
		public ReactParam<global::System.Boolean>? SubmitButtonEnabled { get; set; }
		public ReactParam<global::Android.Widget.CursorAdapter>? SuggestionsAdapter { get; set; }
		public System.EventHandler<global::Android.Widget.SearchView.CloseEventArgs> Close { get; set; }
		public System.EventHandler<global::Android.Views.View.FocusChangeEventArgs> QueryTextFocusChange { get; set; }
		public System.EventHandler<global::Android.Widget.SearchView.QueryTextChangeEventArgs> QueryTextChange { get; set; }
		public System.EventHandler<global::Android.Widget.SearchView.QueryTextSubmitEventArgs> QueryTextSubmit { get; set; }
		public System.EventHandler SearchClick { get; set; }
		public System.EventHandler<global::Android.Widget.SearchView.SuggestionClickEventArgs> SuggestionClick { get; set; }
		public System.EventHandler<global::Android.Widget.SearchView.SuggestionSelectEventArgs> SuggestionSelect { get; set; }
	}
}
