using System.Windows;
using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Sample.Props;
using SharpReact.Wpf;
using SharpReact.Routing.Props;
using SharpReact.Sample.Navigation;
using SharpReact.Wpf.Props;

namespace SharpReact.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WpfTreeRenderer renderer;
        public MainWindow()
        {
            InitializeComponent();
            renderer = new WpfTreeRenderer(CreateTree, this);
            renderer.Render(NewState.Empty);
        }

        private SharpProp CreateTree()
        {
            return new Router
            {
                Children = {
                    new HomeRoute { Content = new FirstPage() },
                    new TypeRoute<FirstPageNavigationArgs> { Content = new FirstPage() },
                    new TypeRoute<SecondPageNavigationArgs>{ Content = new SecondPage() }
                }
            };
            //return new FirstPage();
            //return new StackPanel
            //{
            //    Key = "master",
            //    Children =
            //    {
            //        //new Sharp.TextBlock { Key=0, Text = "Test1" },
            //        //new Sharp.TextBlock { Key=1, Text = "Test2" },
            //        //new Sharp.TextBlock { Key=2, Text = "Test3" },
            //        new Button {
            //            Click = Clicked,
            //            FontSize = 30,
            //            Content = new TextBlock { Text = buttonText }
            //        },
            //        new Button {
            //            Click = Clicked,
            //            FontSize = 30,
            //            Content = new TextBlock { Text = "xxx" }
            //        },
            //    }
            //};
            //return new Button
            //{
            //    Click = Clicked,
            //    FontSize = 30,
            //    Content = new TextBlock { Text = buttonText }
            //};
        }
    }
}
