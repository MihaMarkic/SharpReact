
namespace SharpReact.Wpf.Components
{
	public  class FixedPage<TProps>: FrameworkElement<TProps, System.Windows.Documents.FixedPage>
		where TProps : Props.FixedPage
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Documents.FixedPage();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.PrintTicket.HasValue)
			{
				Element.PrintTicket = nextProps.PrintTicket.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.ContentBox.HasValue)
			{
				Element.ContentBox = nextProps.ContentBox.Value.Value;
			}
			if (nextProps.BleedBox.HasValue)
			{
				Element.BleedBox = nextProps.BleedBox.Value.Value;
			}
		}
	}
}
