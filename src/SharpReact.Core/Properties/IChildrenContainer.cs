using System.Collections.Generic;

namespace SharpReact.Core.Properties
{
    public interface IChildrenContainer
    {
        IList<ISharpProp> Children { get; }
    }
}
