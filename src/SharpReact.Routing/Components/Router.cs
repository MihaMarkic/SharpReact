using SharpReact.Core;
using SharpReact.Core.Properties;
using System.Linq;

namespace SharpReact.Routing.Components
{
    public class Router : SharpComponent<Props.Router, object>
    {
        public override void WillMount()
        {
            ReactServices.Navigation.Navigated += Navigation_Navigated;
            base.WillMount();
        }

        public override void WillUnmount()
        {
            ReactServices.Navigation.Navigated -= Navigation_Navigated;
            base.WillUnmount();
        }

        private void Navigation_Navigated(object sender, Core.Services.Abstract.NavigationEventArgs e)
        {
            Redraw();
        }

        public override ISharpProp Render()
        {
            return Props.Children.FirstOrDefault(r => r.IsMatch());
        }
    }
}
