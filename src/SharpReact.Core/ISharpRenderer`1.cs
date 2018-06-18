using SharpReact.Core.Properties;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SharpReact.Core
{
    public interface ISharpRenderer<TElement>: ISharpRenderer
    {
        TElement ProcessPair(int level, NewState newState, ISharpProp previous, ISharpProp next);
        TElement[] VisitAllCollection(int level, NewState newState, IList<ISharpProp> previous, IList<ISharpProp> next,
            string sourceProperty, string sourceType);
        void UpdateExistingElement(TElement element, ISharpProp prop);
        void RemoveElement(TElement element, ISharpProp prop);
    }
}
