using System.Collections.Generic;
using System.Linq;

namespace SharpReact.Core.Properties
{
    public abstract class SharpChildrenContainerProp<TChild, TComponent> : SharpCompositeProp<TComponent>, IChildrenContainer
        where TChild: ISharpProp
        where TComponent : ISharpComponent, new()
    {
        public List<TChild> Children { get; set; } = new List<TChild>();
        IList<ISharpProp> IChildrenContainer.Children => Children.Cast<ISharpProp>().ToList();
    }
}
