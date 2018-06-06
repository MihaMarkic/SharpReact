using System.Collections.Generic;

namespace SharpReact.Core.MockUI.Test.Components
{
    public interface ISharpWpfTestComponent
    {
        List<int> DidMountCounter { get; }
        List<int> DidUpdateCounter { get; }
        List<int> ShouldUpdateCounter { get; }
        List<int> WillMountCounter { get; }
        List<int> WillReceivePropsCounter { get; }
        List<int> WillUnmountCounter { get; }
        List<int> WillUpdateCounter { get; }
    }
}