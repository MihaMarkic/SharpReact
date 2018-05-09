using Righthand.Immutable;

namespace SharpReact.Sample.Redux.States
{
    public readonly struct SecondPageState
    {
        public string Text { get; }

        public  SecondPageState(string text)
        {
            Text = text;
        }public SecondPageState Clone(Param<string>? text = null)
        {
            return new SecondPageState(text.HasValue ? text.Value.Value : Text);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var o = (SecondPageState)obj;
            return Equals(Text, o.Text);}

        public override int GetHashCode()
        {
            unchecked
			{
				int hash = base.GetHashCode();
				hash = hash * 37 + (Text != null ? Text.GetHashCode() : 0);
				return hash;
			}
        }
    }
}
