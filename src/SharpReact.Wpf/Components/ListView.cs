
namespace SharpReact.Wpf.Components
{
	public  class ListView<TProps, TElement>: ListBox<TProps, TElement>
		where TProps : Props.ListView
		where TElement : System.Windows.Controls.ListView
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.ListView();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.View.HasValue)
			{
				Element.View = nextProps.View.Value.Value;
			}
		}
	}
}
