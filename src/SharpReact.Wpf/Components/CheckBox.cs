
namespace SharpReact.Wpf.Components
{
	public  class CheckBox<TProps, TElement>: ToggleButton<TProps, TElement>
		where TProps : Props.CheckBox
		where TElement : System.Windows.Controls.CheckBox
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.CheckBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
