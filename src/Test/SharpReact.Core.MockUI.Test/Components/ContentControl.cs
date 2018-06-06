﻿namespace SharpReact.Core.MockUI.Test.Components
{
    public class ContentControl<TProps, TElement> : Control<TProps, TElement>
        where TProps : Props.ContentControl
        where TElement : Elements.ContentControl, new()
    {
        public override void AssignProperties(ISharpCreator<Elements.UIElement> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            if (nextProps.Content != null)
            {
                Element.Content = renderer.ProcessPair(level + 1, newState, previous?.Content, nextProps.Content);
            }
        }
    }
}
