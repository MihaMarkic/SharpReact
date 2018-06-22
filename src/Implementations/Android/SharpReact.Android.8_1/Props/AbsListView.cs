using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public abstract partial class AbsListView: AdapterView<global::Android.Widget.IListAdapter>
	{
		public ReactParam<global::Android.Graphics.Color>? CacheColorHint { get; set; }
		public ReactParam<global::Android.Widget.ChoiceMode>? ChoiceMode { get; set; }
		public ReactParam<global::System.Boolean>? FastScrollAlwaysVisible { get; set; }
		public ReactParam<global::System.Boolean>? FastScrollEnabled { get; set; }
		public ReactParam<global::System.Boolean>? ScrollingCacheEnabled { get; set; }
		public ReactParam<global::Android.Graphics.Drawables.Drawable>? Selector { get; set; }
		public ReactParam<global::System.Boolean>? SmoothScrollbarEnabled { get; set; }
		public ReactParam<global::System.Boolean>? StackFromBottom { get; set; }
		public ReactParam<global::System.Boolean>? TextFilterEnabled { get; set; }
		public ReactParam<global::Android.Widget.TranscriptMode>? TranscriptMode { get; set; }
		public System.EventHandler<global::Android.Widget.AbsListView.ScrollEventArgs> Scroll { get; set; }
		public System.EventHandler<global::Android.Widget.AbsListView.ScrollStateChangedEventArgs> ScrollStateChanged { get; set; }
		public System.EventHandler<global::Android.Widget.AbsListView.RecyclerEventArgs> Recycler { get; set; }
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return CacheColorHint;
				yield return ChoiceMode;
				yield return FastScrollAlwaysVisible;
				yield return FastScrollEnabled;
				yield return ScrollingCacheEnabled;
				yield return Selector;
				yield return SmoothScrollbarEnabled;
				yield return StackFromBottom;
				yield return TextFilterEnabled;
				yield return TranscriptMode;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
