using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
	public class BulletDecorator: Decorator
	{
		public ReactParam<global::System.Windows.Media.Brush>? Background { get; set; }
		public ReactParam<global::System.Windows.UIElement>? Bullet { get; set; }
		protected override ISharpStatefulComponent CreateComponent()
		{
			return new Components.BulletDecorator<BulletDecorator, System.Windows.Controls.Primitives.BulletDecorator>();
		}
	}
}
