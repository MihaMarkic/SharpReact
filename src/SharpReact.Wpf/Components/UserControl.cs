
namespace SharpReact.Wpf.Components
{
	public  class UserControl<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.UserControl
		where TElement : System.Windows.Controls.UserControl
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.UserControl();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
