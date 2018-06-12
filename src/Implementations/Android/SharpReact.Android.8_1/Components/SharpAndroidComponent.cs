using Android.Views;
using SharpReact.Core;
using SharpReact.Core.Properties;

namespace SharpReact.Android.Components
{
    public abstract class SharpAndroidComponent<TProps, TState, TElement> : 
        SharpNativeComponent<TProps,TState, TElement, View>
        where TProps : SharpNativeProp
        where TElement: View
    {
    }
}