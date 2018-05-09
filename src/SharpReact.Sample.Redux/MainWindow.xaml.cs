using Sharp.Redux;
using Sharp.Redux.Actions;
using SharpReact.Core;
using SharpReact.Core.Properties;
using SharpReact.Routing.Props;
using SharpReact.Sample.Redux.Navigation;
using SharpReact.Sample.Redux.Props;
using SharpReact.Sample.Redux.Reducers;
using SharpReact.Sample.Redux.States;
using SharpReact.Wpf;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace SharpReact.Sample.Redux
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WpfTreeRenderer renderer;
        public static new AppDispatcher Dispatcher { get; private set; }
        static RootState state;
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            state = new RootState(new FirstPageState(0), new SecondPageState("Initial text"));
            Dispatcher = new AppDispatcher (
                initialState: state,
                reducer: new RootReducer(),
                notificationScheduler: TaskScheduler.FromCurrentSynchronizationContext()
            );
            renderer = new WpfTreeRenderer(CreateTree, this);
            renderer.Render(NewState.Empty);
            Dispatcher.StateChanged += Dispatcher_StateChanged;
            Dispatcher.Start();
        }

        void Dispatcher_StateChanged(object sender, StateChangedEventArgs<RootState> e)
        {
            // there is a bug in redux < 1.1.0 that fires InitAction in a worker task
            if (!(e.Action is InitAction))
            {
                state = e.State;
                renderer.Redraw();
            }
        }

        private SharpProp CreateTree()
        {
            var firstPage = new FirstPage { Number = state.FirstPage.Number };
            return new Router
            {
                Children = {
                    new HomeRoute { Content = firstPage},
                    new TypeRoute<FirstPageNavigationArgs> { Content = firstPage },
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

        protected override void OnClosed(EventArgs e)
        {
            Dispatcher.Dispose();
            base.OnClosed(e);
        }
    }
}
