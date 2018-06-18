using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Android.Props
{
	public partial class ViewAnimator: FrameLayout
	{
		public ReactParam<global::System.Int32>? DisplayedChild { get; set; }
		public ReactParam<global::Android.Views.Animations.Animation>? InAnimation { get; set; }
		public ReactParam<global::Android.Views.Animations.Animation>? OutAnimation { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.ViewAnimator<ViewAnimator, global::Android.Widget.ViewAnimator>();
		}
		public override IEnumerable<IReactParam> AllProperties
		{
			get
			{
				yield return DisplayedChild;
				yield return InAnimation;
				yield return OutAnimation;
				foreach (var p in base.AllProperties)
				{
					yield return p;
				}
			}
		}
	}
}
