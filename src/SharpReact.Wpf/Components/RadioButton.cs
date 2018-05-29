
namespace SharpReact.Wpf.Components
{
	public  class RadioButton<TProps, TElement>: ToggleButton<TProps, TElement>
		where TProps : Props.RadioButton
		where TElement : System.Windows.Controls.RadioButton
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.RadioButton();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.GroupName.HasValue)
			{
				Element.GroupName = nextProps.GroupName.Value.Value;
			}
		}
	}
}
