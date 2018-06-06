using System.Collections.Generic;

namespace SharpReact.Core.Properties
{
    public abstract class SharpProp : ISharpProp, ISharpInternal
    {
        public ISharpStatefulComponent Component { get; private set; }
        public object Key { get; set; }
        public ExtendedKey ExtendedKey => new ExtendedKey(Key, GetType());

        public void Init()
        {
            Component = CreateComponent();
        }
        public void Transfer(ISharpStatefulComponent previous)
        {
            Component = previous;
        }
        protected abstract ISharpStatefulComponent CreateComponent();
        /// <summary>
        /// External entry point from un-mounting.
        /// </summary>
        void ISharpInternal.UnmountComponent()
        {
            UnmountComponent();
        }
        /// <summary>
        /// Internal entry point for un-mounting
        /// </summary>
        protected virtual void UnmountComponent()
        {
            Component.WillUnmount();
        }
        /// <summary>
        /// Un-mounts a list of components.
        /// </summary>
        /// <param name="props"></param>
        protected static void UnmountComponents(IList<ISharpProp> props)
        {
            foreach (var prop in props)
            {
                UnmountComponent(prop);
            }
        }
        /// <summary>
        /// Un-mounts a single component.
        /// </summary>
        /// <param name="props"></param>
        protected static void UnmountComponent(ISharpProp prop)
        {
            ((ISharpInternal)prop)?.UnmountComponent();
        }
    }
}
