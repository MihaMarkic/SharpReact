using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ContentFrameLayout: FrameLayout
	{
		public System.EventHandler AttachedFromWindow { get; set; }
		public System.EventHandler DetachedFromWindow { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ContentFrameLayout<ContentFrameLayout, global::Android.Support.V7.Widget.ContentFrameLayout>();
		}
	}
}
