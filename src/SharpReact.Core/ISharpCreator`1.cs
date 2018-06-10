using SharpReact.Core.Properties;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpReact.Core
{
    public interface ISharpCreator<TElement>
    {
        TElement ProcessPair(int level, NewState newState, ISharpProp previous, ISharpProp next);
        TElement[] VisitAllCollection(int level, NewState newState, IList<ISharpProp> previous, IList<ISharpProp> next,
            string sourceProperty, string sourceType);
    }
}
