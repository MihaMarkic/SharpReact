using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class PageContent<TProps>: FrameworkElement<TProps, System.Windows.Documents.PageContent>
		where TProps : Props.PageContent
	{
		public override void AssignProperties(ISharpCreator<System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
			if (!ReferenceEquals(previous?.GetPageRootCompleted, null) && ReferenceEquals(nextProps.GetPageRootCompleted, null))
			{
				Element.GetPageRootCompleted -= nextProps.GetPageRootCompleted;
			}
			if (ReferenceEquals(previous?.GetPageRootCompleted, null) && !ReferenceEquals(nextProps.GetPageRootCompleted, null))
			{
				Element.GetPageRootCompleted += nextProps.GetPageRootCompleted;
			}
		}
	}
}
