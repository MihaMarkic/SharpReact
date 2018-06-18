using System.Collections.Generic;

namespace SharpReact.Core.Properties
{
    public interface ISharpProp: IKeyedItem
    {
        IEnumerable<ISharpProp> AllChildren { get; }
        IEnumerable<IReactParam> AllProperties { get; }
        void Init();
        void Transfer(ISharpStatefulComponent previous);
        ISharpStatefulComponent Component { get; }
    }
}
