using SharpReact.Core;
using System;

namespace SharpReact.Core.MockUI.Test.Components
{
    public class UIElement<TProps, TElement> : SharpTestComponent<TProps, object, TElement>
        where TProps : Props.UIElement
        where TElement : Elements.UIElement, new()
    {
        public override void AssignProperties(ISharpRenderer<Elements.UIElement> renderer, int level, 
            NewState newState, TProps previous, TProps nextProps)
        {
            base.AssignProperties(renderer, level, newState, previous, nextProps);
            UpdateUIElementWithInstanceProperties(Element, previous, nextProps);
        }
        protected override void UpdateElement(ISharpRenderer renderer, TElement element, TProps props)
        {
            base.UpdateElement(renderer, element, props);
            UpdateUIElementWithInstanceProperties(element, null, props);
        }
        static void UpdateUIElementWithInstanceProperties(TElement element, TProps previous, TProps nextProps)
        {
            if (nextProps.IsEnabled.HasValue)
            {
                element.IsEnabled = nextProps.IsEnabled.Value;
            }
        }
    }
}
