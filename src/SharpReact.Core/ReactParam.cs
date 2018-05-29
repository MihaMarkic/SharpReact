namespace SharpReact.Core
{
    public struct ReactParam<T>
    {
        public T Value { get; set; }

        public static implicit operator ReactParam<T>(T value)
        {
            return new ReactParam<T> { Value = value };
        }

        public static implicit operator T(ReactParam<T> param)
        {
            return param.Value;
        }
    }
}
