using SharpReact.Core;
using SharpReact.Core.Properties;
using System;
using System.Threading.Tasks;
using Terminal.Gui;

namespace SharpReact.Terminal.Gui
{
    public class TerminalGuiTreeRenderer<TRootElement> : SharpRenderer<TRootElement, View>
        where TRootElement : View
    {
        public TerminalGuiTreeRenderer(Func<SharpProp> createTree, TRootElement parent, Action<TRootElement, View> attachChildToRoot, Action<TRootElement, View> detachChildFromRoot, 
            TaskScheduler uiScheduler) :
            base(createTree, parent, attachChildToRoot, detachChildFromRoot, uiScheduler)
        { }
    }
}
