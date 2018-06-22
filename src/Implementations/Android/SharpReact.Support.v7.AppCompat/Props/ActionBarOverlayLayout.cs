using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ActionBarOverlayLayout: ViewGroup
	{
		public ReactParam<global::System.Int32>? ActionBarHideOffset { get; set; }
		public ReactParam<global::System.Boolean>? HideOnContentScrollEnabled { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ActionBarOverlayLayout<ActionBarOverlayLayout, global::Android.Support.V7.Widget.ActionBarOverlayLayout>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return ActionBarHideOffset;
				yield return HideOnContentScrollEnabled;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
