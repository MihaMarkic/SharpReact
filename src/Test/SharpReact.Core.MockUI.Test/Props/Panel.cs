using SharpReact.Core.Properties;
using System;
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Props
{
    public abstract class Panel: FrameworkElement
    {
        public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
        protected override void UnmountComponent()
        {
            UnmountComponents(Children);
            base.UnmountComponent();
        }
    }
}
