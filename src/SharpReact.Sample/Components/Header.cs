using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Sample.Navigation;
using SharpReact.Wpf.Props;

namespace SharpReact.Sample.Components
{
    public class Header : SharpComponent<Props.Header, object>
    {
        public override ISharpProp Render()
        {
            return new StackPanel
            {
                Orientation = System.Windows.Controls.Orientation.Horizontal,
                Children =
                {
                    new TextBlock { Text = Props.PageTitle, Margin=new System.Windows.Thickness(4) },
                    new Button {
                        Content = new TextBlock { Text = "First page"},
                        Click = (s, e) => ReactServices.Navigation.NavigateTo(new FirstPageNavigationArgs())
                    },
                    new Button {
                        Content = new TextBlock { Text = "Second page"},
                        Click = (s, e) => ReactServices.Navigation.NavigateTo(new SecondPageNavigationArgs())
                    }
                },
                Margin = new System.Windows.Thickness(4, 8, 4, 8)
            };
        }
    }
}
