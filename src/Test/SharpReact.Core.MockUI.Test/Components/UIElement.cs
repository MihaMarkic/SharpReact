using SharpReact.Core;
using System;

namespace SharpReact.Core.MockUI.Test.Components
{
    public class UIElement<TProps, TElement> : SharpWpfComponent<TProps, object, TElement>
        where TProps : Props.UIElement
        where TElement : Elements.UIElement, new()
    {
        public override void AssignProperties(ISharpCreator<Elements.UIElement> renderer, int level, 
            NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            //if (nextProps.IsEnabled.HasValue)
            //{
            //    Element.IsEnabled = nextProps.IsEnabled.Value;
            //}
            //if (nextProps.Visibility.HasValue)
            //{
            //    Element.Visibility = nextProps.Visibility.Value;
            //}
        }
    }
}
