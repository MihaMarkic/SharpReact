
namespace SharpReact.Wpf.Components
{
	public  class Button<TProps, TElement>: ButtonBase<TProps, TElement>
		where TProps : Props.Button
		where TElement : System.Windows.Controls.Button
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Button();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.IsDefault.HasValue)
			{
				Element.IsDefault = nextProps.IsDefault.Value.Value;
			}
			if (nextProps.IsCancel.HasValue)
			{
				Element.IsCancel = nextProps.IsCancel.Value.Value;
			}
		}
	}
}
