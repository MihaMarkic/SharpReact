using SharpReact.Core.Properties;

namespace SharpReact.Core.MockUI.Test.Components
{
    public class NestedComposite : SharpComponent<Props.NestedComposite, object>
    {
        public override ISharpProp Render()
        {
            return new Props.SimpleComposite();
        }
    }
}
