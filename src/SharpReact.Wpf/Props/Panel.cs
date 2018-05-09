using SharpReact.Core;
using SharpReact.Core.Properties;
using System;
using System.Collections.Generic;

namespace SharpReact.Wpf.Props
{
    public abstract class Panel: FrameworkElement, IChildrenContainer
    {
        public List<ISharpProp> Children { get; set; } = new List<ISharpProp>();
        IList<ISharpProp> IChildrenContainer.Children => Children;
        protected override ISharpStatefulComponent CreateComponent()
        {
            throw new InvalidOperationException();
        }
    }
}
