using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Routing.Components
{
    public abstract class Route<TProps> : SharpComponent<TProps, object>
        where TProps : SharpProp
    {
    }
}
