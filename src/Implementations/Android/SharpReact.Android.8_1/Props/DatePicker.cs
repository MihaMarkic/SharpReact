using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class DatePicker: FrameLayout
	{
		public ReactParam<global::System.DateTime>? DateTime { get; set; }
		public ReactParam<global::System.Int32>? FirstDayOfWeek { get; set; }
		public ReactParam<global::System.Int64>? MaxDate { get; set; }
		public ReactParam<global::System.Int64>? MinDate { get; set; }
		public System.EventHandler<global::Android.Widget.DatePicker.DateChangedEventArgs> DateChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.DatePicker<DatePicker, global::Android.Widget.DatePicker>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return DateTime;
				yield return FirstDayOfWeek;
				yield return MaxDate;
				yield return MinDate;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
