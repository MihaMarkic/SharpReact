using System;
using System.Windows;
using System.Windows.Controls;
using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Wpf
{
    public class WpfTreeRenderer: SharpRenderer<UIElement>
    {
        public WpfTreeRenderer(Func<SharpProp> createTree, UIElement parent): base(createTree, parent)
        {
        }

        protected override void Attach(UIElement parent, UIElement child)
        {
            if (parent is Panel panel)
            {
                panel.Children.Add(child);
            }
            else if (parent is ContentControl contentControl)
            {
                contentControl.Content = child;
            }
        }

        protected override void Detach(UIElement parent, UIElement child)
        {
            if (parent is Panel panel)
            {
                panel.Children.Remove(child);
            }
            else if (parent is ContentControl contentControl)
            {
                contentControl.Content = null;
            }
        }
    }
}
