
namespace SharpReact.Wpf.Components
{
	public  class GroupBox<TProps, TElement>: HeaderedContentControl<TProps, TElement>
		where TProps : Props.GroupBox
		where TElement : System.Windows.Controls.GroupBox
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.GroupBox();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
		}
	}
}
