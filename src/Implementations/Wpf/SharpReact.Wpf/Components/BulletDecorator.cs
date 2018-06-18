using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class BulletDecorator<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.BulletDecorator
		where TElement : global::System.Windows.Controls.Primitives.BulletDecorator, new()
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.Bullet.HasValue)
			{
				Element.Bullet = nextProps.Bullet.Value.Value;
			}
		}
	}
}
