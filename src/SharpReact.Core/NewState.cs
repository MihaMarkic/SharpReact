using SharpReact.Core.Properties;

namespace SharpReact.Core
{
    public readonly struct NewState
    {
        public static readonly NewState Empty = new NewState(null, null);
        public SharpProp Props { get; }
        public object State { get; }
        public NewState(SharpProp props, object state)
        {
            Props = props;
            State = state;
        }
    }
}
