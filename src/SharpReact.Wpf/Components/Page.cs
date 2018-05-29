
namespace SharpReact.Wpf.Components
{
	public  class Page<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Page
		where TElement : System.Windows.Controls.Page
	{
		protected override void CreateElement()
		{
			Element = (TElement)new System.Windows.Controls.Page();
		}
		public override void AssignProperties(TProps nextProps)
		{
			base.AssignProperties(nextProps);
			if (nextProps.WindowTitle.HasValue)
			{
				Element.WindowTitle = nextProps.WindowTitle.Value.Value;
			}
			if (nextProps.WindowHeight.HasValue)
			{
				Element.WindowHeight = nextProps.WindowHeight.Value.Value;
			}
			if (nextProps.WindowWidth.HasValue)
			{
				Element.WindowWidth = nextProps.WindowWidth.Value.Value;
			}
			if (nextProps.Background.HasValue)
			{
				Element.Background = nextProps.Background.Value.Value;
			}
			if (nextProps.Title.HasValue)
			{
				Element.Title = nextProps.Title.Value.Value;
			}
			if (nextProps.ShowsNavigationUI.HasValue)
			{
				Element.ShowsNavigationUI = nextProps.ShowsNavigationUI.Value.Value;
			}
			if (nextProps.KeepAlive.HasValue)
			{
				Element.KeepAlive = nextProps.KeepAlive.Value.Value;
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
			if (nextProps.Template.HasValue)
			{
				Element.Template = nextProps.Template.Value.Value;
			}
		}
	}
}
