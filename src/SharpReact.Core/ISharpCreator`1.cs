using SharpReact.Core.Properties;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpReact.Core
{
    public interface ISharpCreator<TElement>
    {
        TElement ProcessPair(int level, NewState newState, ISharpProp previous, ISharpProp next);
        void VisitAllCollection(int level, NewState newState, IList<ISharpProp> previous, IList<ISharpProp> next,
            IList elements, string sourceProperty, string sourceType);
    }
}
