
namespace SharpReact.Wpf.Components
{
	public  class Border<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.Border
		where TElement : System.Windows.Controls.Border
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Border();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.BorderThickness.HasValue)
			{
				Element.BorderThickness = nextProps.BorderThickness.Value.Value;
			}
			if (nextProps.Padding.HasValue)
			{
				Element.Padding = nextProps.Padding.Value.Value;
			}
			if (nextProps.CornerRadius.HasValue)
			{
				Element.CornerRadius = nextProps.CornerRadius.Value.Value;
			}
			if (nextProps.BorderBrush.HasValue)
			{
				Element.BorderBrush = nextProps.BorderBrush.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
		}
	}
}
