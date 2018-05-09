using SharpReact.Core.Properties;

namespace SharpReact.Routing.Components
{
    public class HomeRoute : Route<Props.HomeRoute>
    {
        public override ISharpProp Render()
        {
            return Props.Content;
        }
    }
}
