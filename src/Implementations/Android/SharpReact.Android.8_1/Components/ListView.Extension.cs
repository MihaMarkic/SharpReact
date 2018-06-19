using System.Collections.Generic;
using Android.Views;
using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Android.Components
{
    partial class ListView<TProps, TElement>
    {
        ReactAdapter Adapter => (ReactAdapter)Element.Adapter;
        partial void InitElement(TElement element)
        {
            var adapter = new ReactAdapter((ISharpRenderer<global::Android.Views.View>)Renderer);
            element.Adapter = adapter;
        }
        partial void PostAssignListViewProperties(ISharpRenderer<global::Android.Views.View> renderer, int level, NewState newState, TProps previous, TProps nextProps)
        {
            Adapter.AssignItems(nextProps.Items.ToArray());
        }
        public override void AssignContainerProperties(ISharpRenderer<View> renderer, int level, NewState newState, List<ISharpProp> previous, List<ISharpProp> nextProps, string propertyName, string containerName)
        {
            // do nothing because ListView doesn't allow messing with it's View children
        }
    }
}