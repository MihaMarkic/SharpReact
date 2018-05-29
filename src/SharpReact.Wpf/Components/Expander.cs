
namespace SharpReact.Wpf.Components
{
	public  class Expander<TProps, TElement>: HeaderedContentControl<TProps, TElement>
		where TProps : Props.Expander
		where TElement : System.Windows.Controls.Expander
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Expander();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.ExpandDirection.HasValue)
			{
				Element.ExpandDirection = nextProps.ExpandDirection.Value.Value;
			}
			if (nextProps.IsExpanded.HasValue)
			{
				Element.IsExpanded = nextProps.IsExpanded.Value.Value;
			}
			if (!ReferenceEquals(Props?.Expanded, null) && ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded -= nextProps.Expanded;
			}
			if (ReferenceEquals(Props?.Expanded, null) && !ReferenceEquals(nextProps.Expanded, null))
			{
				Element.Expanded += nextProps.Expanded;
			}
			if (!ReferenceEquals(Props?.Collapsed, null) && ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed -= nextProps.Collapsed;
			}
			if (ReferenceEquals(Props?.Collapsed, null) && !ReferenceEquals(nextProps.Collapsed, null))
			{
				Element.Collapsed += nextProps.Collapsed;
			}
		}
	}
}
