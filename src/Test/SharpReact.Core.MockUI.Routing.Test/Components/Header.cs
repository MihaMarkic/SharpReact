using SharpReact.Core.MockUI.Routing.Test.Navigation;
using SharpReact.Core.MockUI.Test.Props;
using SharpReact.Core.Properties;

namespace SharpReact.Core.MockUI.Routing.Test.Components
{
    public class Header : SharpComponent<Props.Header, object>
    {
        public override ISharpProp Render()
        {
            return new StackPanel
            {
                Children =
                {
                    new TextBlock { Text = Props.PageTitle },
                    new Button {
                        Content = new TextBlock { Text = "First page"},
                        Click = (s, e) => ReactServices.Navigation.NavigateTo(new FirstPageNavigationArgs())
                    },
                    new Button {
                        Content = new TextBlock { Text = "Second page"},
                        Click = (s, e) => ReactServices.Navigation.NavigateTo(new SecondPageNavigationArgs())
                    }
                },
            };
        }
    }
}
