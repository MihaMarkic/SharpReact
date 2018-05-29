
namespace SharpReact.Wpf.Components
{
	public  class ListBox<TProps, TElement>: Selector<TProps, TElement>
		where TProps : Props.ListBox
		where TElement : System.Windows.Controls.ListBox
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ListBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.SelectionMode.HasValue)
			{
				Element.SelectionMode = nextProps.SelectionMode.Value.Value;
			}
		}
	}
}
