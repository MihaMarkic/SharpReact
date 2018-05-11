using Sharp.Redux;
using Righthand.Immutable;

namespace SharpReact.Sample.Redux.Actions
{
    public class ChangeSecondPageEntryTextAction: ReduxAction
    {
        public string Text { get; }

        public ChangeSecondPageEntryTextAction(string text) : base()
        {
            Text = text;
        }

        public ChangeSecondPageEntryTextAction Clone(Param<string>? text = null)
        {
            return new ChangeSecondPageEntryTextAction(text.HasValue ? text.Value.Value : Text);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            var o = (ChangeSecondPageEntryTextAction)obj;
            return Equals(Text, o.Text);
        }

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
