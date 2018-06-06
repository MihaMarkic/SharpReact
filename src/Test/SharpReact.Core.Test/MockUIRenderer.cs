using SharpReact.Core.Properties;
using System;
using System.Threading.Tasks;
using Elements = SharpReact.Core.MockUI.Test.Elements;

namespace SharpReact.Core.Test
{
    public class MockUIRenderer : SharpRenderer<Elements.ContentControl, Elements.UIElement>
    {
        public MockUIRenderer(Func<SharpProp> createTree, Elements.ContentControl parent) : base(createTree, parent,
            attachChildToRoot: (r, c) => r.Content = c,
            detachChildFromRoot: (r, c) => r.Content = null,
            TaskScheduler.Current)
        { }
    }
}
