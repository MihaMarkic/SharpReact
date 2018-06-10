using System;
using System.Collections;

namespace SharpReact.Core
{
    public static class ElementSynchronizer
    {
        public static void SyncElements(IList container, IList next)
        {
            for (int i=0; i < Math.Min(container.Count, next.Count); i++)
            {
                if (!ReferenceEquals(container[i], next[i]))
                {
                    container.RemoveAt(i);
                    container.Insert(i, next[i]);
                }
            }
            if (next.Count > container.Count)
            {
                for (int i = container.Count; i < next.Count; i++)
                {
                    container.Add(next[i]);
                }
            }
            if (next.Count < container.Count)
            {
                for (int i = 0; i < container.Count - next.Count; i++)
                {
                    container.RemoveAt(container.Count - 1);
                }
            }
        }
    }
}
