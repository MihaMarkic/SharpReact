using Android.Content;
using Android.Views;
using SharpReact.Core;
using SharpReact.Core.Properties;
using System;
using System.Threading.Tasks;

namespace SharpReact.Android
{
    public class AndroidTreeRenderer<TRootElement> : SharpRenderer<TRootElement, View>
    {
        readonly Context context;
        public AndroidTreeRenderer(Context context, Func<SharpProp> createTree, TRootElement parent, Action<TRootElement, View> attachChildToRoot, Action<TRootElement, View> detachChildFromRoot, 
            TaskScheduler uiScheduler) :
            base(createTree, parent, attachChildToRoot, detachChildFromRoot, uiScheduler)
        {
            this.context = context;
        }
        protected override void CreateElement(ISharpNativeComponent nativeComponent)
        {
            ((Components.IElementCreator)nativeComponent).CreateElement(context);
        }
    }
}
