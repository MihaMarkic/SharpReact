using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public interface ISharpNativeComponent: ISharpStatefulComponent
    {
        void RemoveElement();
        void AssignProperties(ISharpRenderer renderer, int level, NewState newState, ISharpProp previous, ISharpProp nextProps);
    }
}
