using SharpReact.Core.Properties;
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
        public override IEnumerable<ISharpProp> AllChildren
        {
            get
            {
                foreach (var c in Children)
                {
                    yield return c;
                }
                foreach (var c in base.AllChildren)
                {
                    yield return c;
                }
            }
        }
    }
}
