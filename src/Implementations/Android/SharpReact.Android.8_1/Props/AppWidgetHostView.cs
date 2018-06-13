using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class AppWidgetHostView: FrameLayout
	{
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AppWidgetHostView<AppWidgetHostView, global::Android.Appwidget.AppWidgetHostView>();
		}
	}
}
