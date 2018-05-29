
namespace SharpReact.Wpf.Components
{
	public  class DataGridRowHeader<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.DataGridRowHeader
		where TElement : System.Windows.Controls.Primitives.DataGridRowHeader
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DataGridRowHeader();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.SeparatorBrush.HasValue)
			{
				Element.SeparatorBrush = nextProps.SeparatorBrush.Value.Value;
			}
			if (nextProps.SeparatorVisibility.HasValue)
			{
				Element.SeparatorVisibility = nextProps.SeparatorVisibility.Value.Value;
			}
		}
	}
}
