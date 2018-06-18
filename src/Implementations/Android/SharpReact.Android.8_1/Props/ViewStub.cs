using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ViewStub: View
	{
		public ReactParam<global::System.Int32>? InflatedId { get; set; }
		public ReactParam<global::Android.Views.LayoutInflater>? LayoutInflater { get; set; }
		public ReactParam<global::System.Int32>? LayoutResource { get; set; }
		public System.EventHandler<global::Android.Views.ViewStub.InflateEventArgs> InflateEvent { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewStub<ViewStub>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return InflatedId;
				yield return LayoutInflater;
				yield return LayoutResource;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
