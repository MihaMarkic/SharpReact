namespace SharpReact.Core.MockUI.Test.Props
{
    public class Button: ButtonBase
    {
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Button<Button, Elements.Button>();
        }
    }
}