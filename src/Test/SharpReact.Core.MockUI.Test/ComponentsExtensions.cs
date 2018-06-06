using SharpReact.Core.MockUI.Test.Components;
using System.Collections.Generic;
using System.Diagnostics;

namespace SharpReact.Core.MockUI.Test
{
    /// <summary>
    /// Extensions methods for <see cref="ISharpWpfTestComponent"/> to avoid clutter.
    /// </summary>
    /// <remarks>DebuggerStepThrough applied by default.</remarks>
    public static class ComponentsExtensions
    {
        [DebuggerStepThrough]
        public static List<int> DidMountCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).DidMountCounter;
        }
        [DebuggerStepThrough]
        public static List<int> DidUpdateCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).DidUpdateCounter;
        }
        [DebuggerStepThrough]
        public static List<int> ShouldUpdateCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).ShouldUpdateCounter;
        }
        [DebuggerStepThrough]
        public static List<int> WillMountCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).WillMountCounter;
        }
        [DebuggerStepThrough]
        public static List<int> WillReceivePropsCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).WillReceivePropsCounter;
        }
        [DebuggerStepThrough]
        public static List<int> WillUnmountCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).WillUnmountCounter;
        }
        [DebuggerStepThrough]
        public static List<int> WillUpdateCounter(this ISharpStatefulComponent component)
        {
            return ((ISharpWpfTestComponent)component).WillUpdateCounter;
        }
    }
}
