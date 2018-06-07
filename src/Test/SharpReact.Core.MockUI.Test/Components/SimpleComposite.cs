using SharpReact.Core.Properties;

namespace SharpReact.Core.MockUI.Test.Components
{
    public class SimpleComposite : SharpComponent<Props.SimpleComposite, object>
    {
        public override ISharpProp Render()
        {
            return new Props.TextBlock();
        }
    }
}
