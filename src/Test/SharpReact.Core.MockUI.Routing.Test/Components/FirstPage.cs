using SharpReact.Core.MockUI.Test.Props;
using SharpReact.Core.Properties;
using System;

namespace SharpReact.Core.MockUI.Routing.Test.Components
{
    public struct FirstPageState
    {
        public int Number { get; set; }
    }
    public class FirstPage : SharpComponent<Props.FirstPage, FirstPageState>
    {
        public override ISharpProp Render()
        {
            return new StackPanel
            {
                Children =
                {
                    new Props.Header { PageTitle = "First" },
                    new Button
                    {
                        Click = Clicked,
                        FontSize = 30,
                        Content = new TextBlock { Text = State.Number.ToString() }
                    }
                },
            };
        }

        public void Clicked(object sender, EventArgs e)
        {
            var newState = new FirstPageState { Number = State.Number + 1 };
            SetState(newState);
        }
    }
}
