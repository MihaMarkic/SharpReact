using SharpReact.Core.Properties;
using SharpReact.Core.Services.Abstract;

namespace SharpReact.Routing.Components
{
    public class TypeRoute<T> : Route<Props.TypeRoute<T>>
        where T : NavigationArgs
    {
        public override ISharpProp Render()
        {
            return Props.Content;
        }
    }
}
