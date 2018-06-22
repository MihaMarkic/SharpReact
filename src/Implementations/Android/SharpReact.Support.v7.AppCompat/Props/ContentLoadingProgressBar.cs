using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class ContentLoadingProgressBar: ProgressBar
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ContentLoadingProgressBar<ContentLoadingProgressBar, global::Android.Support.V4.Widget.ContentLoadingProgressBar>();
		}
	}
}
