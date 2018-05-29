
namespace SharpReact.Wpf.Components
{
	public  class Separator<TProps, TElement>: Control<TProps, TElement>
		where TProps : Props.Separator
		where TElement : System.Windows.Controls.Separator
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Separator();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
