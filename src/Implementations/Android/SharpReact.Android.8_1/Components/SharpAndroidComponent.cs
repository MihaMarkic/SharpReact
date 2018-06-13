using Android.Views;
using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Android.Components
{
    internal interface IElementCreator
    {
        void CreateElement(global::Android.Content.Context context);
    }
    public abstract class SharpAndroidComponent<TProps, TState, TElement> :
        SharpNativeComponent<TProps, TState, TElement, View>, IElementCreator
        where TProps : SharpNativeProp
        where TElement : View
    {
        public abstract void CreateElement(global::Android.Content.Context context);
    }
}