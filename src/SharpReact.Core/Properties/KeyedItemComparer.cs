using System.Collections.Generic;

namespace SharpReact.Core.Properties
{
    public class KeyedItemEqualityComparer<T> : IEqualityComparer<T>
        where T : IKeyedItem
    {
        public bool Equals(T x, T y)
        {
            if (x == null && y == null)
            {
                return true;
            }
            else if (x == null || y == null)
            {
                return false;
            }
            else
            {
                return x.ExtendedKey == y.ExtendedKey;
            }
        }

        public int GetHashCode(T obj)
        {
            return obj.ExtendedKey.GetHashCode();
        }
    }
}
