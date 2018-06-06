﻿using SharpReact.Core.Properties;
using System;
using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Components
{
    public static class SharpWpfComponentTestCounter
    {
        [ThreadStatic]
        public static int EventCounter;
        public static void ResetCounter() => EventCounter = 0;
    }
    public class SharpWpfComponent<TProps, TState, TElement> : SharpNativeComponent<TProps, TState, TElement, Elements.UIElement>, ISharpWpfTestComponent
            where TProps : SharpNativeProp
            where TElement : Elements.UIElement, new()
    {
        // the gals below track event order
        public List<int> ShouldUpdateCounter { get; private set; } = new List<int>();
        public List<int> WillUpdateCounter { get; private set; } = new List<int>();
        public List<int> DidUpdateCounter { get; private set; } = new List<int>();
        public List<int> WillMountCounter { get; private set; } = new List<int>();
        public List<int> DidMountCounter { get; private set; } = new List<int>();
        public List<int> WillUnmountCounter { get; private set; } = new List<int>();
        public List<int> WillReceivePropsCounter { get; private set; } = new List<int>();
        public override void WillMount()
        {
            Element = new TElement();
            base.WillMount();
            WillMountCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
        }
        public override bool ShouldUpdate(TProps nextProps, TState nextState)
        {
            ShouldUpdateCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
            return base.ShouldUpdate(nextProps, nextState);
        }
        public override void WillUpdate()
        {
            WillUpdateCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
            base.WillUpdate();
        }
        public override void DidUpdate(TProps nextProps, TState nextState)
        {
            DidUpdateCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
            base.DidUpdate(nextProps, nextState);
        }
        public override void DidMount()
        {
            base.DidMount();
            DidMountCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
        }
        public override void WillUnmount()
        {
            base.WillUnmount();
            WillUnmountCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
        }
        public override void WillReceiveProps(TProps nextProps)
        {
            base.WillReceiveProps(nextProps);
            WillReceivePropsCounter.Add(SharpWpfComponentTestCounter.EventCounter++);
        }
    }
}