
namespace SharpReact.Wpf.Components
{
	public  class SelectiveScrollingGrid<TProps, TElement>: Grid<TProps, TElement>
		where TProps : Props.SelectiveScrollingGrid
		where TElement : System.Windows.Controls.Primitives.SelectiveScrollingGrid
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Primitives.SelectiveScrollingGrid();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
