
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public abstract class ButtonBase<TProps, TElement> : ContentControl<TProps, TElement>
        where TProps : Props.ButtonBase
        where TElement : System.Windows.Controls.Primitives.ButtonBase, new()
    {
        public override void AssignProperties(ISharpCreator<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (!ReferenceEquals(Props?.Click, null) && ReferenceEquals(nextProps.Click, null))
            {
                Element.Click -= nextProps.Click;
            }
            if (ReferenceEquals(Props?.Click, null) && !ReferenceEquals(nextProps.Click, null))
            {
                Element.Click += nextProps.Click;
            }
        }
    }
}
