using System.Windows;

namespace SharpReact.Sample.Redux
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // connect visualizer
            //ReduxVisualizer.Init(
            //    IoCRegistrar.Container.Resolve<ITodoReduxDispatcher>(),
            //    new string[] { "Todo.Engine.Actions" });
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            //IoCRegistrar.Container.Dispose();
            base.OnExit(e);
        }
    }
}
