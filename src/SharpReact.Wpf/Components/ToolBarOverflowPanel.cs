
namespace SharpReact.Wpf.Components
{
	public  class ToolBarOverflowPanel<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.ToolBarOverflowPanel
		where TElement : System.Windows.Controls.Primitives.ToolBarOverflowPanel
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.ToolBarOverflowPanel();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.WrapWidth.HasValue)
			{
				Element.WrapWidth = nextProps.WrapWidth.Value.Value;
			}
		}
	}
}
