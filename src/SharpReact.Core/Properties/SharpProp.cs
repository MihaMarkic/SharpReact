namespace SharpReact.Core.Properties
{
    public abstract class SharpProp : ISharpProp
    {
        public ISharpStatefulComponent Component { get; private set; }
        public object Key { get; set; }

        public void Init()
        {
            Component = CreateComponent();
        }
        public void Transfer(ISharpStatefulComponent previous)
        {
            Component = previous;
        }
        protected abstract ISharpStatefulComponent CreateComponent();
    }
}
