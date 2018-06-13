using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class TvView: ViewGroup
	{
		public System.EventHandler<global::Android.Media.TV.TvView.UnhandledInputEventEventArgs> UnhandledInputEvent { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TvView<TvView, global::Android.Media.TV.TvView>();
		}
	}
}
