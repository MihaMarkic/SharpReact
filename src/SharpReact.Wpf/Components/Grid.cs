
namespace SharpReact.Wpf.Components
{
	public  class Grid<TProps, TElement>: Panel<TProps, TElement>
		where TProps : Props.Grid
		where TElement : System.Windows.Controls.Grid
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Grid();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.ShowGridLines.HasValue)
			{
				Element.ShowGridLines = nextProps.ShowGridLines.Value.Value;
			}
		}
	}
}
