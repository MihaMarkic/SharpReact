
namespace SharpReact.Wpf.Components
{
	public  class Control<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Control
		where TElement : System.Windows.Controls.Control
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Control();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.BorderBrush.HasValue)
			{
				Element.BorderBrush = nextProps.BorderBrush.Value.Value;
			}
			if (nextProps.BorderThickness.HasValue)
			{
				Element.BorderThickness = nextProps.BorderThickness.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.Foreground.HasValue)
			{
				Element.Foreground = nextProps.Foreground.Value.Value;
			}
			if (nextProps.FontFamily.HasValue)
			{
				Element.FontFamily = nextProps.FontFamily.Value.Value;
			}
			if (nextProps.FontSize.HasValue)
			{
				Element.FontSize = nextProps.FontSize.Value.Value;
			}
			if (nextProps.FontStretch.HasValue)
			{
				Element.FontStretch = nextProps.FontStretch.Value.Value;
			}
			if (nextProps.FontStyle.HasValue)
			{
				Element.FontStyle = nextProps.FontStyle.Value.Value;
			}
			if (nextProps.FontWeight.HasValue)
			{
				Element.FontWeight = nextProps.FontWeight.Value.Value;
			}
			if (nextProps.HorizontalContentAlignment.HasValue)
			{
				Element.HorizontalContentAlignment = nextProps.HorizontalContentAlignment.Value.Value;
			}
			if (nextProps.VerticalContentAlignment.HasValue)
			{
				Element.VerticalContentAlignment = nextProps.VerticalContentAlignment.Value.Value;
			}
			if (nextProps.TabIndex.HasValue)
			{
				Element.TabIndex = nextProps.TabIndex.Value.Value;
			}
			if (nextProps.IsTabStop.HasValue)
			{
				Element.IsTabStop = nextProps.IsTabStop.Value.Value;
			}
			if (nextProps.Padding.HasValue)
			{
				Element.Padding = nextProps.Padding.Value.Value;
			}
			if (nextProps.Template.HasValue)
			{
				Element.Template = nextProps.Template.Value.Value;
			}
			if (!ReferenceEquals(Props?.PreviewMouseDoubleClick, null) && ReferenceEquals(nextProps.PreviewMouseDoubleClick, null))
			{
				Element.PreviewMouseDoubleClick -= nextProps.PreviewMouseDoubleClick;
			}
			if (ReferenceEquals(Props?.PreviewMouseDoubleClick, null) && !ReferenceEquals(nextProps.PreviewMouseDoubleClick, null))
			{
				Element.PreviewMouseDoubleClick += nextProps.PreviewMouseDoubleClick;
			}
			if (!ReferenceEquals(Props?.MouseDoubleClick, null) && ReferenceEquals(nextProps.MouseDoubleClick, null))
			{
				Element.MouseDoubleClick -= nextProps.MouseDoubleClick;
			}
			if (ReferenceEquals(Props?.MouseDoubleClick, null) && !ReferenceEquals(nextProps.MouseDoubleClick, null))
			{
				Element.MouseDoubleClick += nextProps.MouseDoubleClick;
			}
		}
	}
}
