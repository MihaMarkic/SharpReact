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
    }
}
