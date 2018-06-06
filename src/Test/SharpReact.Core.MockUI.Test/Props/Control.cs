namespace SharpReact.Core.MockUI.Test.Props
{
    public class Control: FrameworkElement
    {
        public ReactParam<double>? FontSize { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.Control<Control, Core.MockUI.Test.Elements.Control>();
        }
    }
}
