using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public abstract class SharpComponent<TProps, TState> : SharpStatefulComponent<TProps, TState, object>, ISharpComponent
        where TProps : SharpProp
    {
        void ISharpComponent.AssignProperties(object nextProps)
        {
            AssignProperties((TProps)nextProps);
        }
        protected virtual void AssignProperties(TProps props)
        { }
    }
}
