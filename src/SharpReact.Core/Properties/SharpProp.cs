﻿using System.Collections.Generic;

namespace SharpReact.Core.Properties
{
    public abstract class SharpProp : ISharpProp, ISharpInternal
    {
        readonly static SharpProp[] emptyChildren = new SharpProp[0];
        readonly static IReactParam[] emptyProps = new IReactParam[0];
        public ISharpStatefulComponent Component { get; private set; }
        public object Key { get; set; }
        public ExtendedKey ExtendedKey => new ExtendedKey(Key, GetType());

        public void Init()
        {
            if (Component == null)
            {
                Component = CreateComponent();
            }
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
        protected static void UnmountComponents(IEnumerable<ISharpProp> props)
        {
            foreach (var prop in props)
            {
                UnmountComponent(prop);
            }
        }
        /// <summary>
        /// Un-mounts a single component.
        /// </summary>
        /// <param name="prop"></param>
        protected static void UnmountComponent(ISharpProp prop)
        {
            ((ISharpInternal)prop)?.UnmountComponent();
        }

        public virtual IEnumerable<ISharpProp> AllChildren => emptyChildren;
        public virtual IEnumerable<IReactParam> AllProperties => emptyProps;
    }
}
