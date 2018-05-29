
namespace SharpReact.Wpf.Components
{
	public  class UniformGrid<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.UniformGrid
		where TElement : System.Windows.Controls.Primitives.UniformGrid
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.UniformGrid();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.FirstColumn.HasValue)
			{
				Element.FirstColumn = nextProps.FirstColumn.Value.Value;
			}
			if (nextProps.Columns.HasValue)
			{
				Element.Columns = nextProps.Columns.Value.Value;
			}
			if (nextProps.Rows.HasValue)
			{
				Element.Rows = nextProps.Rows.Value.Value;
			}
		}
	}
}
