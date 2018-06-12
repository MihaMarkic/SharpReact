using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
	public  class Page<TProps, TElement>: FrameworkElement<TProps, TElement>
		where TProps : Props.Page
		where TElement : global::System.Windows.Controls.Page, new()
	{
		public override void AssignProperties(ISharpCreator<global::System.Windows.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
		{
			base.AssignProperties(renderer, level, newState, previous, nextProps);
			if (nextProps.Content != null)
			{
				Element.Content = renderer.ProcessPair(level + 1, newState, previous?.Content, nextProps.Content);
			}
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
