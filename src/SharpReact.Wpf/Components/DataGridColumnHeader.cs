
namespace SharpReact.Wpf.Components
{
	public  class DataGridColumnHeader<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.DataGridColumnHeader
		where TElement : System.Windows.Controls.Primitives.DataGridColumnHeader
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.DataGridColumnHeader();
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
