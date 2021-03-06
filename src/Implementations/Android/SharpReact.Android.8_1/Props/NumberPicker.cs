using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class NumberPicker: LinearLayout
	{
		public ReactParam<global::System.Int32>? MaxValue { get; set; }
		public ReactParam<global::System.Int32>? MinValue { get; set; }
		public ReactParam<global::System.Int32>? Value { get; set; }
		public ReactParam<global::System.Boolean>? WrapSelectorWheel { get; set; }
		public System.EventHandler<global::Android.Widget.NumberPicker.ScrollEventArgs> Scroll { get; set; }
		public System.EventHandler<global::Android.Widget.NumberPicker.ValueChangeEventArgs> ValueChanged { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.NumberPicker<NumberPicker, global::Android.Widget.NumberPicker>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return MaxValue;
				yield return MinValue;
				yield return Value;
				yield return WrapSelectorWheel;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
