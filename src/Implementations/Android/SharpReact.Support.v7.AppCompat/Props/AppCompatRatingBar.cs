using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;
using SharpReact.Android.Props;

namespace SharpReact.Support.v7.AppCompat.Props
{
	public partial class AppCompatRatingBar: RatingBar
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AppCompatRatingBar<AppCompatRatingBar, global::Android.Support.V7.Widget.AppCompatRatingBar>();
		}
	}
}
