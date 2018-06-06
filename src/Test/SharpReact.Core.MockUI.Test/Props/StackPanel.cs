
namespace SharpReact.Core.MockUI.Test.Props
{
    public class StackPanel: Panel
    {
        //public Orientation? Orientation { get; set; }
        protected override ISharpStatefulComponent CreateComponent()
        {
            return new Components.StackPanel<StackPanel, Elements.StackPanel>();
        }
    }
}
