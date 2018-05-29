
namespace SharpReact.Wpf.Components
{
	public  class InkPresenter<TProps, TElement>: Decorator<TProps, TElement>
		where TProps : Props.InkPresenter
		where TElement : System.Windows.Controls.InkPresenter
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.InkPresenter();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Strokes.HasValue)
			{
				Element.Strokes = nextProps.Strokes.Value.Value;
			}
		}
	}
}
