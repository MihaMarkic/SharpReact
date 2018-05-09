using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public abstract class SharpComponent<TProps, TState> : SharpStatefulComponent<TProps, TState>, ISharpComponent
        where TProps : SharpProp
    {
        public void AssignElement(object element)
        {
            Element = element;
        }
    }
}
