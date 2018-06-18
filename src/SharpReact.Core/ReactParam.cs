using System;

namespace SharpReact.Core
{
    public readonly struct ReactParam<T>: IReactParam, IEquatable<ReactParam<T>>, IEquatable<T>
    {
        public ReactParam(T value) => Value = value;
        public T Value { get; }

        public static implicit operator ReactParam<T>(T value)
        {
            return new ReactParam<T>(value);
        }

        public static implicit operator T(ReactParam<T> param)
        {
            return param.Value;
        }

        public override bool Equals(object other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            else if (other is T otherValue)
            {
                return Equals(otherValue);
            }
            else if (other is ReactParam<T> otherParam)
            {
                return Equals(otherParam);
            }
            return false;
        }

        public bool Equals(IReactParam other)
        {
            if (other is ReactParam<T> otherParam)
            {
                return Equals(otherParam);
            }
            return false;
        }
        public bool Equals(ReactParam<T> other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            return Equals(other.Value);
        }
        public bool Equals(T other)
        {
            if (ReferenceEquals(Value, null))
            {
                return ReferenceEquals(other, null);
            }
            return Equals(Value, other);
        }
        public override int GetHashCode()
        {
            return ReferenceEquals(Value, null) ? 0: Value.GetHashCode();
        }
        public static bool operator ==(ReactParam<T> p1, ReactParam<T> p2) => p1.Equals(p2);
        public static bool operator !=(ReactParam<T> p1, ReactParam<T> p2) => !(p1 == p2);
        public static bool operator ==(ReactParam<T> p1, T p2) => p1.Equals(p2);
        public static bool operator !=(ReactParam<T> p1, T p2) => !(p1 == p2);
        public static bool operator ==(T p1, ReactParam<T> p2) => p2.Equals(p1);
        public static bool operator !=(T p1, ReactParam<T> p2) => !(p1 == p2);
    }
}
