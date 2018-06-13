using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Sample.Redux.Actions;
using SharpReact.Sample.Redux.States;
using SharpReact.Wpf.Props;
using System.Windows;

namespace SharpReact.Sample.Redux.Components
{
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
                        Content = new TextBlock { Text = Props.Number.ToString() }
                    }
                },
            };
        }

        public void Clicked(object sender, RoutedEventArgs e)
        {
            MainWindow.Dispatcher.Dispatch(new IncreaseFirstPageNumberAction(1));
        }
    }
}
