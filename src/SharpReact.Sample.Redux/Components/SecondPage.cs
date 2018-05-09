using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Sample.Redux.States;
using SharpReact.Wpf.Props;
using System;
using System.Windows;

namespace SharpReact.Sample.Redux.Components
{
    public class SecondPage : SharpComponent<Props.SecondPage, SecondPageState>
    {
        public override ISharpProp Render()
        {
            return new StackPanel
            {
                Orientation = System.Windows.Controls.Orientation.Vertical,
                Margin = new Thickness(8),
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

        private void TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            //var textBox = (System.Windows.Controls.TextBox)sender;
            //if (textBox.Text.Length < 51)
            //{
            //    SetState(new SecondPageState { Text = textBox.Text.Substring(0, Math.Min(51, textBox.Text.Length)) });
            //}
        }
    }
}
