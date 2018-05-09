using Righthand.Immutable;

namespace SharpReact.Sample.Redux.States
{
    public readonly struct FirstPageState
    {
        public int Number { get; }

        public FirstPageState(int number)
        {
            Number = number;
        }public FirstPageState Clone(Param<int>? number = null)
        {
            return new FirstPageState(number.HasValue ? number.Value.Value : Number);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var o = (FirstPageState)obj;
            return Equals(Number, o.Number);
        }

        public override int GetHashCode()
        {
            unchecked
			{
				int hash = base.GetHashCode();
				hash = hash * 37 + Number.GetHashCode();
				return hash;
			}
        }
    }
}
