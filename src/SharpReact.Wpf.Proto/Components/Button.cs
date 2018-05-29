using SharpReact.Wpf.Props;

namespace SharpReact.Wpf.Components
{
    public class Button<TProps, TElement> : ButtonBase<TProps, TElement>
        where TProps : Button
        where TElement : System.Windows.Controls.Button, new()
    {
    }
}
