using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Elements
{
    public class Panel : FrameworkElement {
        public List<UIElement> Children { get; } = new List<UIElement>();
    }
}
