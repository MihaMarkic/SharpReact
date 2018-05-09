using SharpReact.Core;
using System;
using System.Windows;

namespace SharpReact.Wpf.Props
{
    public abstract class ButtonBase: ContentControl
    {
        public RoutedEventHandler Click { get; set; }
    }
}
