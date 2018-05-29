
namespace SharpReact.Wpf.Components
{
	public  class Label<TProps, TElement>: ContentControl<TProps, TElement>
		where TProps : Props.Label
		where TElement : System.Windows.Controls.Label
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Label();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Target.HasValue)
			{
				Element.Target = nextProps.Target.Value.Value;
			}
		}
	}
}
