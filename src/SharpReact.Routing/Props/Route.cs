using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Routing.Props
{
    public abstract class Route<TComponent> : SharpContainerProp<SharpProp, TComponent>, IRoute
                where TComponent : ISharpComponent, new()
    {
        public abstract bool IsMatch();
    }
}
