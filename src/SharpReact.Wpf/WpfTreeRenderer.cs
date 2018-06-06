﻿using SharpReact.Core;
using SharpReact.Core.Properties;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace SharpReact.Wpf
{
    public abstract class WpfTreeRenderer<TRootElement>: SharpRenderer<TRootElement, UIElement>
        where TRootElement : UIElement
    {
        public WpfTreeRenderer(Func<SharpProp> createTree, TRootElement parent, Action<TRootElement, UIElement> attachChildToRoot, Action<TRootElement, UIElement> detachChildFromRoot, TaskScheduler uiScheduler) : 
            base(createTree, parent, attachChildToRoot, detachChildFromRoot, uiScheduler)
        {}
    }
}
