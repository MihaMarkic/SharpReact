using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ActionBarContextView: AbsActionBarView
	{
		public ReactParam<global::Java.Lang.ICharSequence>? SubtitleFormatted { get; set; }
		public ReactParam<global::System.String>? Subtitle { get; set; }
		public ReactParam<global::Java.Lang.ICharSequence>? TitleFormatted { get; set; }
		public ReactParam<global::System.String>? Title { get; set; }
		public ReactParam<global::System.Boolean>? TitleOptional { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ActionBarContextView<ActionBarContextView, global::Android.Support.V7.Widget.ActionBarContextView>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return SubtitleFormatted;
				yield return Subtitle;
				yield return TitleFormatted;
				yield return Title;
				yield return TitleOptional;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
