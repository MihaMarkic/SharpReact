
namespace SharpReact.Wpf.Components
{
	public  class WrapPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.WrapPanel
		where TElement : System.Windows.Controls.WrapPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.WrapPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.ItemWidth.HasValue)
			{
				Element.ItemWidth = nextProps.ItemWidth.Value.Value;
			}
			if (nextProps.ItemHeight.HasValue)
			{
				Element.ItemHeight = nextProps.ItemHeight.Value.Value;
			}
			if (nextProps.Orientation.HasValue)
			{
				Element.Orientation = nextProps.Orientation.Value.Value;
			}
		}
	}
}
