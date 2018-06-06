using System;

namespace SharpReact.Core.Properties
{
    public struct ExtendedKey
    {
        public object Key { get; }
        public Type Type { get; }
        public ExtendedKey(object key, Type type)
        {
            Key = key;
            Type = type;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var o = (ExtendedKey)obj;
            return Equals(Key, o.Key) && Equals(Type, o.Type);
        }
        public static bool operator ==(ExtendedKey left, ExtendedKey right)
        {
            return left.Equals(right);
        }
        public static bool operator !=(ExtendedKey left, ExtendedKey right) => !(left == right);
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = base.GetHashCode();
                hash = hash * 37 + (Key != null ? Key.GetHashCode() : 0);
                hash = hash * 37 + (Type != null ? Type.GetHashCode() : 0);
                return hash;
            }
        }
    }
}
