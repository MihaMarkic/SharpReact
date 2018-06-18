using System.Collections.Generic;
using SharpReact.Core.Properties;

namespace SharpReact.Core.MockUI.Test.Props
{
    public class ContentControl : Control
    {
        public ISharpProp Content { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.ContentControl<ContentControl, Core.MockUI.Test.Elements.ContentControl>();
        }
        protected override void UnmountComponent()
        {
            UnmountComponent(Content);
            base.UnmountComponent();
        }
        public override IEnumerable<ISharpProp> AllChildren
        {
            get
            {
                yield return Content;
                foreach (var c in base.AllChildren)
                {
                    yield return c;
                }
            }
        }
    }
}
