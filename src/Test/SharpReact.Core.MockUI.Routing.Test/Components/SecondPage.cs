using SharpReact.Core.MockUI.Test.Props;
using SharpReact.Core.Properties;
using System;
using Elements = SharpReact.Core.MockUI.Test.Elements;

namespace SharpReact.Core.MockUI.Routing.Test.Components
{
    public struct SecondPageState
    {
        public string Text { get; set; }
    }
    public class SecondPage : SharpComponent<Props.SecondPage, SecondPageState>
    {
        public override ISharpProp Render()
        {
            return new StackPanel
            {
                Children =
                {
                    new Props.Header { PageTitle = "Second" },
                    new TextBox
                    {
                        FontSize = 40,
                        Text = State.Text,
                        TextChanged = TextChanged
                    }
                },
            };
        }

        private void TextChanged(object sender, EventArgs e)
        {
            var textBox = (Elements.TextBox)sender;
            if (textBox.Text.Length < 51)
            {
                SetState(new SecondPageState { Text = textBox.Text.Substring(0, Math.Min(51, textBox.Text.Length)) });
            }
        }
    }
}
