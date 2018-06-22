using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class SearchView: LinearLayoutCompat
	{
		public ReactParam<global::System.Boolean>? Iconified { get; set; }
		public ReactParam<global::System.Int32>? ImeOptions { get; set; }
		public ReactParam<global::System.Int32>? InputType { get; set; }
		public ReactParam<global::System.Int32>? MaxWidth { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? QueryHintFormatted { get; set; }
		public ReactParam<global::System.String>? QueryHint { get; set; }
		public ReactParam<global::System.Boolean>? QueryRefinementEnabled { get; set; }
		public ReactParam<global::System.Boolean>? SubmitButtonEnabled { get; set; }
		public ReactParam<global::Android.Support.V4.Widget.CursorAdapter>? SuggestionsAdapter { get; set; }
		public System.EventHandler<global::Android.Support.V7.Widget.SearchView.CloseEventArgs> Close { get; set; }
		public System.EventHandler<global::Android.Support.V7.Widget.SearchView.QueryTextChangeEventArgs> QueryTextChange { get; set; }
		public System.EventHandler<global::Android.Support.V7.Widget.SearchView.QueryTextSubmitEventArgs> QueryTextSubmit { get; set; }
		public System.EventHandler<global::Android.Support.V7.Widget.SearchView.SuggestionClickEventArgs> SuggestionClick { get; set; }
		public System.EventHandler<global::Android.Support.V7.Widget.SearchView.SuggestionSelectEventArgs> SuggestionSelect { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.SearchView<SearchView, global::Android.Support.V7.Widget.SearchView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Iconified;
				yield return ImeOptions;
				yield return InputType;
				yield return MaxWidth;
				yield return QueryHintFormatted;
				yield return QueryHint;
				yield return QueryRefinementEnabled;
				yield return SubmitButtonEnabled;
				yield return SuggestionsAdapter;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
