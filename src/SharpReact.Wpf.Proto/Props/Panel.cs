using SharpReact.Core;
using SharpReact.Core.Properties;
using System;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
    public abstract class Panel: FrameworkElement
    {
        public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
        protected override void UnmountComponent()
        {
            UnmountComponents(Children);
            base.UnmountComponent();
        }
    }
}
