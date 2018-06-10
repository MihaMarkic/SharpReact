using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public abstract class Panel<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Panel
		where TElement : System.Windows.Controls.Panel, new()
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			{
				var elements = renderer.VisitAllCollection(level, newState, previous?.Children, nextProps.Children, nameof(Element.Children), nameof(SharpReact.Wpf.Props.Panel));
				ElementSynchronizer.SyncElements(Element.Children, elements);
			}
			if (nextProps.IsItemsHost.HasValue)
			{
				Element.IsItemsHost = nextProps.IsItemsHost.Value.Value;
			}
		}
	}
}
