using Sharp.Redux;
using Righthand.Immutable;

namespace SharpReact.Sample.Redux.Actions
{
    public class IncreaseFirstPageNumberAction: ReduxAction
    {
        public int Diff { get; }

        public IncreaseFirstPageNumberAction(int diff) : base()
        {
            Diff = diff;
        }public IncreaseFirstPageNumberAction Clone(Param<int>? diff = null)
        {
            return new IncreaseFirstPageNumberAction(diff.HasValue ? diff.Value.Value : Diff);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var o = (IncreaseFirstPageNumberAction)obj;
            return Equals(Diff, o.Diff);}

        public override int GetHashCode()
        {
            unchecked
			{
				int hash = base.GetHashCode();
				hash = hash * 37 + Diff.GetHashCode();
				return hash;
			}
        }
    }
}
