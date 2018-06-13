using Righthand.Immutable;

namespace SharpReact.Sample.Redux.States
{
    public readonly struct RootState
    {
        public FirstPageState FirstPage { get; }
        public SecondPageState SecondPage { get; }

        public RootState(FirstPageState firstPage, SecondPageState secondPage)
        {
            FirstPage = firstPage;
            SecondPage = secondPage;
        }public RootState Clone(Param<FirstPageState>? firstPage = null, Param<SecondPageState>? secondPage = null)
        {
            return new RootState(firstPage.HasValue ? firstPage.Value.Value : FirstPage,
				secondPage.HasValue ? secondPage.Value.Value : SecondPage);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var o = (RootState)obj;
            return Equals(FirstPage, o.FirstPage) && Equals(SecondPage, o.SecondPage);}

        public override int GetHashCode()
        {
            unchecked
			{
				int hash = base.GetHashCode();
				hash = hash * 37 + FirstPage.GetHashCode();
				hash = hash * 37 + SecondPage.GetHashCode();
				return hash;
			}
        }
    }
}
