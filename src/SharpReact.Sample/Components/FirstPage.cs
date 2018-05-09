using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Wpf.Props;
using System.Windows;

namespace SharpReact.Sample.Components
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
                Orientation = System.Windows.Controls.Orientation.Vertical,
                Margin = new Thickness(8),
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

        public void Clicked(object sender, RoutedEventArgs e)
        {
            var newState = new FirstPageState { Number = State.Number + 1 };
            SetState(newState);
        }
    }
}
