
namespace SharpReact.Wpf.Components
{
	public  class BulletDecorator<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.BulletDecorator
		where TElement : System.Windows.Controls.Primitives.BulletDecorator
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.BulletDecorator();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
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
