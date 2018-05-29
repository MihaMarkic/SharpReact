
namespace SharpReact.Wpf.Components
{
	public  class PageContent<TProps>: FrameworkElement<TProps, System.Windows.Documents.PageContent>
		where TProps : Props.PageContent
	{
		protected override void CreateElement()
		{
			Element = new System.Windows.Documents.PageContent();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.Source.HasValue)
			{
				Element.Source = nextProps.Source.Value.Value;
			}
			if (nextProps.Child.HasValue)
			{
				Element.Child = nextProps.Child.Value.Value;
			}
			if (!ReferenceEquals(Props?.GetPageRootCompleted, null) && ReferenceEquals(nextProps.GetPageRootCompleted, null))
			{
				Element.GetPageRootCompleted -= nextProps.GetPageRootCompleted;
			}
			if (ReferenceEquals(Props?.GetPageRootCompleted, null) && !ReferenceEquals(nextProps.GetPageRootCompleted, null))
			{
				Element.GetPageRootCompleted += nextProps.GetPageRootCompleted;
			}
		}
	}
}
