using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Wpf.Props
{
    public class ContentControl : Control
    {
        public ISharpProp Content { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.ContentControl<ContentControl, System.Windows.Controls.ContentControl>();
        }
        protected override void UnmountComponent()
        {
            UnmountComponent(Content);
            base.UnmountComponent();
        }
    }
}
