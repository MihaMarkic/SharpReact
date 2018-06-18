
using System.Windows;
using SharpReact.Core;

namespace SharpReact.Wpf.Components
{
    public abstract class Panel<TProps, TElement> : FrameworkElement<TProps, TElement>
        where TProps : Props.Panel
        where TElement : System.Windows.Controls.Panel, new()
    {
        public override void AssignProperties(ISharpRenderer<UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //if (!ReferenceEquals(source.Children, null))
            //{
            //    UIElementCollection.Populate(renderer, source.Children, item.Children);
            //}
        }
    }
}
