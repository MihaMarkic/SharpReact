
namespace SharpReact.Wpf.Components
{
	public  class Menu<TProps, TElement>: MenuBase<TProps, TElement>
		where TProps : Props.Menu
		where TElement : System.Windows.Controls.Menu
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Menu();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsMainMenu.HasValue)
			{
				Element.IsMainMenu = nextProps.IsMainMenu.Value.Value;
			}
		}
	}
}
