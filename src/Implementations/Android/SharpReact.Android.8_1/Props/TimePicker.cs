using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class TimePicker: FrameLayout
	{
		public ReactParam<global::System.Int32>? Hour { get; set; }
		public ReactParam<global::System.Int32>? Minute { get; set; }
		public System.EventHandler<global::Android.Widget.TimePicker.TimeChangedEventArgs> TimeChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.TimePicker<TimePicker, global::Android.Widget.TimePicker>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return Hour;
				yield return Minute;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
