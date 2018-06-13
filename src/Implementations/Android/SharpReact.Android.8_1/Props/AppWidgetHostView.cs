using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public class AppWidgetHostView: FrameLayout
	{
		public List<ISharpProp> Views { get; set; } = new List<ISharpProp>();
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.AppWidgetHostView<AppWidgetHostView, global::Android.Appwidget.AppWidgetHostView>();
		}
	}
}
