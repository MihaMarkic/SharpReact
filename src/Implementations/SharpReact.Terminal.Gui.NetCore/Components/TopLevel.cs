using Terminal.Gui;

namespace SharpReact.Terminal.Gui.Components
{
    public abstract class TopLevel<TProps, TElement> : View<TProps, TElement>
        where TProps : Props.TopLevel
        where TElement : Toplevel
    {
    }
}
