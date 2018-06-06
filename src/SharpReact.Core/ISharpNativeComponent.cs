using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public interface ISharpNativeComponent: ISharpStatefulComponent
    {
        void AssignProperties(ISharpRenderer renderer, int level, NewState newState, ISharpProp previous, ISharpProp nextProps);
    }
}
