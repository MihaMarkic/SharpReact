using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class FixedPage<TProps>: FrameworkElement<TProps, global::System.Windows.Documents.FixedPage>
		where TProps : Props.FixedPage
	{
		public override void AssignProperties(ISharpRenderer<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Children, nextProps.Children, nameof(Element.Children), nameof(SharpReact.Wpf.Props.FixedPage));
				ElementSynchronizer.SyncElements(Element.Children, elements);
			}
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
